using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Cleaner {
	public class RecycleBinInfo {
		public static bool TryGetInfo( string rootPath, out (long Size, long NumberOfItems) result ) {
			var rbi = new SHQUERYRBINFO {
				cbSize = checked((uint) Marshal.SizeOf<SHQUERYRBINFO>())
			};

			if( Win32.SHQueryRecycleBin( rootPath, ref rbi ) == 0 ) {
				result = (rbi.i64Size, rbi.i64NumItems);
				return true;
			}
			else {
				result = default;
				return false;
			}
		}
	}
}
