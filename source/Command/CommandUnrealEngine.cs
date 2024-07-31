using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner {

	internal class CommandUnrealEngine {

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
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


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static long Execute() {
			long byteSize = 0;

			byteSize += DeleteCacth();
			byteSize += DeleteIntermediate();

			return byteSize;
		}
	}
}
