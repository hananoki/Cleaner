using System;
using System.Collections.Generic;
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
			return $"{( fileSize / 1024f / 1024f ).ToString( "#.##" )} MB";
		}

		[MethodImpl( MethodImplOptions.AggressiveInlining )]
		public static long Size( string filePath ) {
			return ( new FileInfo( filePath ) ).Length;
		}
	}
}
