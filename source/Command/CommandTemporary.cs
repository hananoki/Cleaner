using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner {

	public class CommandTemporary {

		public static long Execute() {
			string tempPath = Path.GetTempPath();
			var tempDirs = Directory.EnumerateDirectories( tempPath, "*" )
				.Select( x => Path.GetFileName( x ) )
				.ToArray();

			return FileUtils.DeleteDirectories(
				[ tempPath ],
				tempDirs );
		}

	}
}
