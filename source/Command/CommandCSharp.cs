
namespace Cleaner {

	internal class CommandCSharp {

		public static long Execute() {
			var searchPaths = UserSettings.instance.cs_project_paths.ToArray();

			return FileUtils.DeleteDirectories(
				searchPaths,
				[ "obj", "bin" ] );
		}

	}
}
