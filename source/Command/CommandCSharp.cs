using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Win32Api;
using System.IO;
using System.Drawing;

namespace Cleaner.Command {
	internal class CommandCSharp {

		static long DeleteIntermediate() {
			var searchPaths = UserSettings.instance.cs_project_paths.ToArray();

			return FileUtils.DeleteDirectories(
				searchPaths,
				[ "obj", "bin" ] );
		}

		async public static void Execute( object sender, EventArgs e ) {
			using( var c = new CommandScopeOp( [ DeleteIntermediate ] ) ) {
				await Task.Run( () => {
					c.Execute();
			} );
			}
		}
	}
}
