using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Command {
	public class CommandTemporary {
		async public static void Execute( object sender, EventArgs e ) {
			using( new CommandScope() ) {
				await Task.Run( () => {
					string tempPath = Path.GetTempPath();

					foreach( var s in Directory.EnumerateDirectories( tempPath, "*" ) ) {

						try {
							if( Directory.Exists( s ) ) {
								Directory.Delete( s, true );
							}
							Log.Info( Path.GetFileName( s ) );
						}
						catch( Exception uae ) {
							Log.Error( $"Exception: {Path.GetFileName( s )}" );
						}
					}

					foreach( var s in Directory.EnumerateFiles( tempPath, "*" ) ) {

						try {
							if( File.Exists( s ) ) {
								File.Delete( s );
							}
							Log.Info( Path.GetFileName( s ) );
						}
						catch( Exception uae ) {
							Log.Error( $"Exception: {Path.GetFileName( s )}" );
						}
					}
				} );
			}
		}
	}
}
