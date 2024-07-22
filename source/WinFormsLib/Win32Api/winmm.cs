using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8981 // 型名には、小文字の ASCII 文字のみが含まれています。このような名前は、プログラミング言語用に予約されている可能性があります。

namespace Win32Api {

	public static class winmm {
#if ENABLE_WINMM_DLL
		//サウンドを再生するWin32 APIの宣言
		[Flags]
		public enum PlaySoundFlags : int {
			SND_SYNC = 0x0000,
			SND_ASYNC = 0x0001,
			SND_NODEFAULT = 0x0002,
			SND_MEMORY = 0x0004,
			SND_LOOP = 0x0008,
			SND_NOSTOP = 0x0010,
			SND_NOWAIT = 0x00002000,
			SND_ALIAS = 0x00010000,
			SND_ALIAS_ID = 0x00110000,
			SND_FILENAME = 0x00020000,
			SND_RESOURCE = 0x00040004,
			SND_PURGE = 0x0040,
			SND_APPLICATION = 0x0080
		}

		[DllImport( "winmm.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto )]
		public static extern bool PlaySound( string pszSound, IntPtr hmod, PlaySoundFlags fdwSound );

		[DllImport( "winmm.dll" )]
		public static extern bool PlaySound( byte[] pszSound, IntPtr hmod, PlaySoundFlags fdwSound );

#endif
	}
}
