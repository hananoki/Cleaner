using System.Runtime.InteropServices;
using System;

[StructLayout( LayoutKind.Sequential )]
public struct SHQUERYRBINFO {
	public uint cbSize;
	public long i64Size;
	public long i64NumItems;
}

[StructLayout( LayoutKind.Sequential )]
public struct SHFILEINFO {
	public IntPtr hIcon;
	public IntPtr iIcon;
	public uint dwAttributes;
	[MarshalAs( UnmanagedType.ByValTStr, SizeConst = 260 )]
	public string szDisplayName;
	[MarshalAs( UnmanagedType.ByValTStr, SizeConst = 80 )]
	public string szTypeName;
};


public static partial class Win32 {
#if ENABLE_SHELL32_DLL

	// flags for SHEmptyRecycleBin
	//
	// �I�u�W�F�N�g�̍폜���m�F����_�C�A���O �{�b�N�X�͕\������܂���B
	public const uint SHERB_NOCONFIRMATION = 0x00000001;
	// �i�s�󋵂������_�C�A���O �{�b�N�X�͕\������܂���B
	public const uint SHERB_NOPROGRESSUI = 0x00000002;
	// ���삪��������ƁA�T�E���h�͍Đ�����܂���B
	public const uint SHERB_NOSOUND = 0x00000004;

	
	// SHGetFileInfo�֐��Ŏg�p����t���O
	public const uint SHGFI_ICON = 0x100; // �A�C�R���E���\�[�X�̎擾
	public const uint SHGFI_LARGEICON = 0x0; // �傫���A�C�R��
	public const uint SHGFI_SMALLICON = 0x1; // �������A�C�R��
																					 // SHGetFileInfo�֐��Ŏg�p����\����

	/**
	https://www.umayadia.com/cssample/sample0201/Sample264FolderDelete.htm������p
	*/

	#region �S�~���폜
	/// <summary>
	/// �t�@�C�����R�s�[�E�ړ��E�폜�E���O�ύX���܂��B
	/// </summary>
	/// <param name="lpFileOp"></param>
	/// <returns>���펞0�B�ُ펞�̒l�̈Ӗ��� https://docs.microsoft.com/ja-jp/windows/win32/api/shellapi/nf-shellapi-shfileoperationa ���Q�ƁB</returns>
	[DllImport( "shell32.dll", SetLastError = true, CharSet = CharSet.Unicode )]
	public static extern int SHFileOperation( [In] ref SHFILEOPSTRUCT lpFileOp );

	[StructLayout( LayoutKind.Sequential, CharSet = CharSet.Unicode )]
	public struct SHFILEOPSTRUCT {
		public IntPtr hwnd;
		[MarshalAs( UnmanagedType.U4 )] public FileFuncFlags wFunc;
		[MarshalAs( UnmanagedType.LPWStr )] public string pFrom;
		[MarshalAs( UnmanagedType.LPWStr )] public string pTo;
		[MarshalAs( UnmanagedType.U2 )] public FILEOP_FLAGS fFlags;
		[MarshalAs( UnmanagedType.Bool )] public bool ffAnyOperationsAborted;
		public IntPtr hNameMappings; //FOF_WANTMAPPINGHANDLE�t���O�ƂƂ��Ɏg�p���܂��B
		[MarshalAs( UnmanagedType.LPWStr )] public string lplpszProgressTitle; //FOF_SIMPLEPROGRESS�t���O�ƂƂ��Ɏg�p���܂��B
	}

	public enum FileFuncFlags {
		/// <summary>pFrom ���� pTo �Ƀt�@�C�����ړ����܂��B</summary>
		FO_MOVE = 0x1,
		/// <summary>pFrom ���� pTo �Ƀt�@�C�����R�s�[���܂��B</summary>
		FO_COPY = 0x2,
		/// <summary>pFrom ����t�@�C�����폜���܂��B</summary>
		FO_DELETE = 0x3,
		/// <summary>pFrom �̃t�@�C���̖��O��ύX���܂��B�����t�@�C����ΏۂƂ���ꍇ�� FO_MOVE ���g�p���܂��B</summary>
		FO_RENAME = 0x4
	}

	[Flags]
	public enum FILEOP_FLAGS : short {
		/// <summary>pTo�ɂ�pFrom�ɂP�΂P�őΉ����镡���̃R�s�[����w�肵�܂��B</summary>
		FOF_MULTIDESTFILES = 0x1,
		/// <summary>���̃t���O�͎g�p���܂���B</summary>
		FOF_CONFIRMMOUSE = 0x2,
		/// <summary>�i���󋵂̃_�C�A���O��\�����܂���B</summary>
		FOF_SILENT = 0x4,
		/// <summary>�����̃t�@�C�������ɑ��݂���ꍇ�A�V�������O��t���܂��B</summary>
		FOF_RENAMEONCOLLISION = 0x8,
		/// <summary>�m�F�_�C�A���O��\�������A���ׂāu�͂��v��I���������̂Ƃ��܂��B</summary>
		FOF_NOCONFIRMATION = 0x10,
		/// <summary>FOF_RENAMEONCOLLISION�t���O�ɂ��t�@�C�����̏Փˉ�������������ꍇ�ASHFILEOPSTRUCT.hNameMappings�ɐV���t�@�C�����̏����i�[���܂��B���̏���SHFreeNameMappings���g���ĊJ������K�v������܂��B</summary>
		FOF_WANTMAPPINGHANDLE = 0x20,
		/// <summary>�\�ł���΁A��������ɖ߂���悤�ɂ��܂��B</summary>
		FOF_ALLOWUNDO = 0x40,
		/// <summary>���C���h�J�[�h���g�p���ꂽ�ꍇ�A�t�@�C���݂̂�ΏۂƂ��܂��B</summary>
		FOF_FILESONLY = 0x80,
		/// <summary>�i���󋵂̃_�C�A���O��\�����܂����A�X�̃t�@�C�����͕\�����܂���B</summary>
		FOF_SIMPLEPROGRESS = 0x100,
		/// <summary>�V�����t�H���_�[�̍쐬����O�Ƀ��[�U�[�Ɋm�F���܂���B</summary>
		FOF_NOCONFIRMMKDIR = 0x200,
		/// <summary>�G���[���������Ă��_�C�A���O��\�����܂���B</summary>
		FOF_NOERRORUI = 0x400,
		/// <summary>�t�@�C���̃Z�L�����e�B�����̓R�s�[���܂���B�R�s�[��̃t�@�C���̓R�s�[��̃t�H���_�[�̃Z�L�����e�B�����������p���܂��B</summary>
		FOF_NOCOPYSECURITYATTRIBS = 0x800,
		/// <summary>�T�u�f�B���N�g���[���ċA�I�ɏ������܂���B����͊���̓���ł��B</summary>
		FOF_NORECURSION = 0x1000,
		/// <summary>�O���[�v�Ƃ��ĘA�����Ă���t�@�C���͈ړ����܂���B�w�肳�ꂽ�t�@�C���������ړ����܂��B</summary>
		FOF_NO_CONNECTED_ELEMENTS = 0x2000,
		/// <summary>�t�@�C�����P�v�I�ɍ폜�����ꍇ�A�x����\�����܂��B���̃t���O��FOF_NOCONFIRMATION���D�悳��܂��B </summary>
		FOF_WANTNUKEWARNING = 0x4000,
		/// <summary>UI��\�����܂���B</summary>
		FOF_NO_UI = FOF_SILENT | FOF_NOCONFIRMATION | FOF_NOERRORUI | FOF_NOCONFIRMMKDIR
	}
	#endregion


	[DllImport( "shell32.dll" )]
	public static extern IntPtr SHGetFileInfo( string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags );

	/**
	 * �w�肵���h���C�u�̂��ݔ�����ɂ��܂��B
	 * https://learn.microsoft.com/ja-jp/windows/win32/api/shellapi/nf-shellapi-shemptyrecyclebina
	 */
	[DllImport( "shell32.dll" )]
	public static extern int SHEmptyRecycleBin( IntPtr hwnd, [In] string pszRootPath, uint dwFlags );

	[DllImport( "shell32.dll" )]
	public static extern int SHQueryRecycleBin( [In] string pszRootPath, ref SHQUERYRBINFO pSHQueryRBInfo );


	#region Icon

	//[DllImport( "Shell32.dll", CharSet = CharSet.Unicode )]
	//public static extern uint ExtractIconEx( string lpszFile, int nIconIndex,
	//	IntPtr[] phiconLarge, IntPtr phiconSmall, uint nIcons );

	//[DllImport( "Shell32.dll", CharSet = CharSet.Unicode )]
	//public static extern uint ExtractIconEx( string lpszFile, int nIconIndex,
	//		IntPtr phiconLarge, IntPtr phiconSmall, uint nIcons );

	// ExtractIconEx �����̈����w����@�ɂ��A�I�[�o�[���[�h��`����B
	//[DllImport( "Shell32.dll", CharSet = CharSet.Unicode )]
	//public static extern uint ExtractIconEx( string lpszFile, int nIconIndex, IntPtr[] phiconLarge, IntPtr[] phiconSmall, uint nIcons );
	//[DllImport( "Shell32.dll", CharSet = CharSet.Unicode )]
	//public static extern uint ExtractIconEx( string lpszFile, int nIconIndex, IntPtr[] phiconLarge, IntPtr phiconSmall, uint nIcons );
	//[DllImport( "Shell32.dll", CharSet = CharSet.Unicode )]
	//public static extern uint ExtractIconEx( string lpszFile, int nIconIndex, IntPtr phiconLarge, IntPtr[] phiconSmall, uint nIcons );
	//[DllImport( "Shell32.dll", CharSet = CharSet.Unicode )]
	//public static extern uint ExtractIconEx( string lpszFile, int nIconIndex, out IntPtr phiconLarge, out IntPtr phiconSmall, uint nIcons );

	//[DllImport( "User32.dll" )]
	//public static extern bool DestroyIcon( IntPtr hIcon );

	#endregion

	/**
	 * �w�肵���t�@�C���ɑ΂��đ�������s���܂��B
	 * https://learn.microsoft.com/ja-jp/windows/win32/api/shellapi/nf-shellapi-shellexecutea
	 */
	[DllImport( "Shell32.dll", CharSet = CharSet.Auto, SetLastError = true )]
	public static extern IntPtr ShellExecute( IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd );

#endif
}

