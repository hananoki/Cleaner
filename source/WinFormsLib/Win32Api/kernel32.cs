using System.Runtime.InteropServices;
using System.Text;
using System;

public static partial class Win32 {
#if ENABLE_KERNEL32_DLL

	[StructLayout( LayoutKind.Sequential )]
	public struct SystemInfo {
		public uint dwOemId;
		public uint dwPageSize;
		public IntPtr lpMinimumApplicationAddress;
		public IntPtr lpMaximumApplicationAddress;
		public uint dwActiveProcessorMask;
		public uint dwNumberOfProcessors;
		public uint dwProcessorType;
		public uint dwAllocationGranularity;
		public uint dwProcessorLevel;
		public uint dwProcessorRevision;
	}

	[DllImport( "kernel32.dll" )]
	public static extern bool AllocConsole();

	[DllImport( "kernel32.dll" )]
	public static extern bool FreeConsole();

	[DllImport( "kernel32.dll", ExactSpelling = true )]
	public static extern void GetSystemInfo( out SystemInfo ptmpsi );

	[DllImport( "kernel32.dll" )]
	public static extern uint FormatMessage( uint dwFlags, IntPtr lpSource, uint dwMessageId, uint dwLanguageId, StringBuilder lpBuffer, int nSize, IntPtr Arguments );

	[DllImport( "kernel32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto )]
	public static extern uint GetShortPathName( [MarshalAs( UnmanagedType.LPTStr )] string lpszLongPath, [MarshalAs( UnmanagedType.LPTStr )] StringBuilder lpszShortPath, uint cchBuffer );

#endif
}
