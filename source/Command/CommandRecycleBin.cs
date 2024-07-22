using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Win32Api;

namespace Cleaner.Command {
	public class CommandRecycleBin {
		async public static void Execute( object sender, EventArgs e ) {
			using( new CommandScope() ) {
				long byteSize = 0;
				foreach( var driveInfo in DriveInfo.GetDrives() ) {
					if( RecycleBinInfo.TryGetInfo( driveInfo.Name, out var info ) ) {
						byteSize += info.Size;
					}
				}
				float mega = byteSize / 1024f / 1024f;

				Log.Info( $"ごみ箱を空にします: {mega.ToString( "#.##" )} MB" );

				await Task.Run( () => {
					shell32.SHEmptyRecycleBin(
							0,
							"",
									RecycleFlags.SHERB_NOCONFIRMATION
									| RecycleFlags.SHERB_NOPROGRESSUI
									| RecycleFlags.SHERB_NOSOUND );

				} );
			}
		}
	}
}
