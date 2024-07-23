using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Command {
	public class CommandTemporary {


		static long Delete2() {
			string tempPath = Path.GetTempPath();
			var tempDirs = Directory.EnumerateDirectories( tempPath, "*" )
				.Select( x => Path.GetFileName( x ) )
				.ToArray();

			return FileUtils.DeleteDirectories(
				[ tempPath ],
				tempDirs );
		}

		async public static void Execute( object sender, EventArgs e ) {
			using var c = new CommandScopeOp( [ Delete2 ] );
			await Task.Run( () => {
				c.Execute();
			} );
		}
	}
}
