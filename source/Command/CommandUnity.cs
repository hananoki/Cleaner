using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner {
	internal class CommandUnity {
		static bool Has( string s ) {
			bool assets = Directory.Exists( Path.Combine( s, "Assets" ) );
			bool projectSettings = Directory.Exists( Path.Combine( s, "ProjectSettings" ) );

			return assets && projectSettings;
		}


		public static long Execute() {

			foreach( var d in Directory.EnumerateDirectories( "C:\\Hananoki.Dev", "*", SearchOption.AllDirectories ) ) {
				var unityPath = d;

				if( !Has( unityPath ) ) continue;

				foreach( var f in Directory.EnumerateFiles( unityPath, "*.csproj" ) ) {
					Log.Info( $"Delete: {Path.GetFileName( f )}" );
					File.Delete( f );
				}

				var lib = Path.Combine( unityPath, "Library" );
				if( Directory.Exists( lib ) ) {
					try {
						Directory.Delete( lib, true );
						Log.Info( $"Delete: {lib}" );
					}
					catch( Exception ex ) {
						Log.Error( $"{ex.Message}" );
					}
				}
			}

			return 0;

		}
	}
}
