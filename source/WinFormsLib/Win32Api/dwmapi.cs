using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Win32Api {
#if false
	#region dwmapi.dll
	internal class dwmapi {
		[StructLayout( LayoutKind.Sequential )]
		public struct MARGINS {
			public int leftWidth;
			public int rightWidth;
			public int topHeight;
			public int bottomHeight;
		}

		[DllImport( "dwmapi.dll", PreserveSig = true )]
		public static extern int DwmExtendFrameIntoClientArea( IntPtr hwnd, ref MARGINS margins );

		[DllImport( "dwmapi.dll", PreserveSig = false )]
		public static extern bool DwmIsCompositionEnabled();

		[DllImport( "dwmapi.dll" )]
		public static extern int DwmIsCompositionEnabled( out bool enabled );
	}
	#endregion
#endif
}
