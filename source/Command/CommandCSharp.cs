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
		async public static void Execute( object sender, EventArgs e ) {
			using( new CommandScope() ) {
				await Task.Run( () => {
					long totalSize = 0;
					string[] folderNames = {
						"obj" ,
						"bin"
						};

					foreach( var d in UserSettings.instance.cs_project_paths ) {
						foreach( var fn in folderNames ) {
							foreach( var dd in Directory.EnumerateDirectories( d, fn, SearchOption.AllDirectories ) ) {
								long folderSize = 0;

								foreach( var f in Directory.EnumerateFiles( dd, "*", SearchOption.AllDirectories ) ) {
									long fileSize = FileUtils.Size( f );

									try {
										File.Delete( f );

										folderSize += fileSize;
									}
									catch( Exception ex ) {
										Log.Error( $"Exception: {ex.Message}" );
									}
								}
								if( 0 < folderSize ) {
									Log.Info( $"{dd}: {FileUtils.MB( folderSize )}" );
								}
								totalSize += folderSize;
							}
						}
					}
					Log.Info( $"削除した合計サイズ: {FileUtils.MB( totalSize )}" );
				} );
			}
		}
	}
}
