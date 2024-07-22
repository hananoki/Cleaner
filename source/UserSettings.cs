using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cleaner {
	internal class UserSettings {
		[Browsable( false )]
		public int width { get; set; } = 800;

		[Browsable( false )]
		public int height { get; set; } = 600;

		[Browsable( false )]
		public int x { get; set; }

		[Browsable( false )]
		public int y { get; set; }

		public List<string> cs_project_paths { get; set; } = new();


		static public UserSettings instance;
		static string jsonFilePath => $@"{Environment.GetFolderPath( Environment.SpecialFolder.Personal )}\Cleaner.json";

		public static void Load() {
			if( File.Exists( jsonFilePath ) ) {
				instance = JsonSerializer.Deserialize<UserSettings>( File.ReadAllText( jsonFilePath ) );
			}
			else {
				instance = new();
			}
		}


		public static void Save() {
			JsonSerializerOptions options = new JsonSerializerOptions() {
				Encoder = System.Text.Encodings.Web.JavaScriptEncoder.
				 Create( System.Text.Unicode.UnicodeRanges.All )
			};
			options.WriteIndented = true;
			File.WriteAllText(
				jsonFilePath,
				JsonSerializer.Serialize( UserSettings.instance, options ) );
		}


		/////////////////////////////////////////////////////////////////////////
		public static void RollbackWindow( UI_MainWindow form ) {
			form.Location = new Point( Math.Max( UserSettings.instance.x, 0 ), Math.Max( UserSettings.instance.y, 0 ) );

			form.Width = instance.width;
			form.Height = instance.height;
		}


		/////////////////////////////////////////////////////////////////////////
		public static void BackupWindow( UI_MainWindow form ) {
			instance.x = form.Location.X;
			instance.y = form.Location.Y;
			instance.width = form.Width;
			instance.height = form.Height;
		}
	}
}
