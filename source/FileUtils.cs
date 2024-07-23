using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner {
	public class FileUtils {
		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static string MB( long fileSize ) {
			if( fileSize == 0 ) return "0 MB";
			return $"{( fileSize / 1024f / 1024f ).ToString( "0.00" )} MB";
		}

		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static long Size( string filePath ) {
			return ( new FileInfo( filePath ) ).Length;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="searchPaths"></param>
		/// <param name="searchDirs"></param>
		public static long DeleteDirectories( string[] searchPaths, string[] searchDirs ) {

			long totalSize = 0;

			foreach( var s in searchDirs ) {
				foreach( var projPath in searchPaths ) {

					if( string.IsNullOrEmpty( projPath ) ) continue;

					UC_StatusBar.Info( $"{projPath}" );

					// 指定ディレクトリがない
					if( !Directory.Exists( projPath ) ) continue;

					foreach( var d in Directory.EnumerateDirectories( projPath, s, SearchOption.AllDirectories ) ) {
						try {
							// 列挙したディレクトリが何らかの理由で存在してない
							if( !Directory.Exists( d ) ) continue;

							UC_StatusBar.Info( $"{d}" );

							var folderSize = DeleteDirectory( d );

							if( 0 < folderSize ) {
								Log.Info( $"{d}: {MB( folderSize )}" );
							}

							totalSize += folderSize;
							Directory.Delete( d, true );
						}
						catch( Exception uae ) {
							Log.Error( $"{uae.Message}" );
						}
					}
				}
			}

			//Log.Info( $"削除した合計サイズ: {MB( totalSize )}" );

			return totalSize;
		}


		/// <summary>
		/// 指定したディレクトリを削除して、削除した合計ファイルサイズを返す
		/// </summary>
		/// <param name="dirPath"></param>
		/// <returns>削除した合計ファイルサイズ</returns>
		public static long DeleteDirectory( string dirPath ) {
			long folderSize = 0;

			foreach( var f in Directory.EnumerateFiles( dirPath, "*", SearchOption.AllDirectories ) ) {
				long fileSize = Size( f );

				try {
					File.Delete( f );

					folderSize += fileSize;
				}
				catch( Exception /*ex*/ ) {
					//Log.Error( $"Exception: {ex.Message}" );
				}
			}

			return folderSize;
		}
	}
}
