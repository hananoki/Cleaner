using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleaner.Properties;

namespace Cleaner {
	public class CommandRecycleBin {

		public static long Execute() {

			long byteSize = 0;
			foreach( var driveInfo in DriveInfo.GetDrives() ) {
				if( RecycleBinInfo.TryGetInfo( driveInfo.Name, out var info ) ) {
					byteSize += info.Size;
				}
			}
			//float mega = byteSize / 1024f / 1024f;

			Log.Info( $"{Resources.EmptyingTheTrash}" );

			Win32.SHEmptyRecycleBin(
					0,
					"",
							Win32.SHERB_NOCONFIRMATION
							| Win32.SHERB_NOPROGRESSUI
							| Win32.SHERB_NOSOUND );

			return byteSize;
		}
	}
}
