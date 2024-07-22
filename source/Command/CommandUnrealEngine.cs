using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Command {
	internal class CommandUnrealEngine {
		async public static void Execute( object sender, EventArgs e ) {
			using( new CommandScope() ) {
				await Task.Run( () => {
					var localApplicationDataPath = Environment.GetFolderPath( Environment.SpecialFolder.LocalApplicationData );

					var unrealEnginePath = Path.Combine( localApplicationDataPath, "UnrealEngine" );

					string[] names = { "DerivedDataCache", "SwarmCache" };

					foreach( var s in names ) {
						foreach( var d in Directory.EnumerateDirectories( unrealEnginePath, s, SearchOption.AllDirectories ) ) {
							try {
								Directory.Delete( d, true );
								Log.Info( d );
							}
							catch( Exception uae ) {
								Log.Info( $"Exception: {Path.GetFileName( d )}" );
							}
						}
					}
				} );
			};
		}
	}
}
