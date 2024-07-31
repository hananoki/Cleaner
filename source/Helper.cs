using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cleaner {
	internal class Helper {

		static bool bConsoleInit;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="force"></param>
		public static void SelectConsoleWindow(bool enable) {

			if( enable ) {
				Win32.AllocConsole();
				// コンソールとstdoutの紐づけを行う。無くても初回は出力できるが、表示、非表示を繰り返すとエラーになる。
				Console.SetOut( new StreamWriter( Console.OpenStandardOutput() ) { AutoFlush = true } );
			}
			else {
				Win32.FreeConsole();
			}

		}


		/// <summary>
		/// 
		/// </summary>
		public static void ApplyLanguage() {
			var ii = UI_MainWindow.instance;

			if( UserSettings.instance.debugDefaultLang ) {
				Thread.CurrentThread.CurrentUICulture = new CultureInfo( "" );
				ii.EmitChangeCulture();
			}
			else {
				// Windowsの表示言語をもとにアプリの表示言語も切り替え
				//switch( CultureInfo.CurrentCulture.IetfLanguageTag ) {
				//	case "ja-JP":
				//		ChangeCulture( "ja-JP" );
				//		break;
				//	default:
				//		ChangeCulture( "" );
				//		break;
				//}
				switch( CultureInfo.CurrentCulture.IetfLanguageTag ) {
					case "ja-JP":
						//Thread.CurrentThread.CurrentUICulture = new CultureInfo( "ja-JP" );
						ii.EmitChangeCulture( "ja-JP" );
						break;
					default:
						//Thread.CurrentThread.CurrentUICulture = new CultureInfo( "" );
						ii.EmitChangeCulture();
						break;
				}
				//ii.ChangeCulture();
			}
		}


		public static Image GetCommandImage( ECommandType commandType ) {

			var i = UI_MainWindow.instance;

			if( commandType == ECommandType.Unity ) {
				return i.imageList1.Images[ 2 ];
			}
			if( commandType == ECommandType.UnrealEngine ) {
				return i.imageList1.Images[ 1 ];
			}
			return i.imageList1.Images[ 0 ];
		}
	}
}
