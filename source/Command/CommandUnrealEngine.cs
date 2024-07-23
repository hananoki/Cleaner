using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Command {
	internal class CommandUnrealEngine {
		static long DeleteCacth() {
			var localApplicationDataPath = Environment.GetFolderPath( Environment.SpecialFolder.LocalApplicationData );

			var unrealEnginePath = Path.Combine( localApplicationDataPath, "UnrealEngine" );

			return FileUtils.DeleteDirectories(
				[ unrealEnginePath ],
				[ "DerivedDataCache", "SwarmCache" ] );
		}



		/// <summary>
		/// 中間ファイル類の削除
		/// </summary>
		static long DeleteIntermediate() {
			var projectPaths = UserSettings.instance.unreal_project_paths;

			return FileUtils.DeleteDirectories(
				projectPaths.ToArray(),
				[ "Intermediate", "Binaries" ] );
		}



		async public static void Execute( object sender, EventArgs e ) {
			using( var c = new CommandScopeOp( [ DeleteCacth, DeleteIntermediate ] ) ) {
				await Task.Run( () => {
					c.Execute();
				} );
			}
		}
	}
}
