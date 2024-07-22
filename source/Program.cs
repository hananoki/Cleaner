using System;
using System.Threading;
using System.Windows.Forms;

namespace Cleaner {
	internal static class Program {
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			using( var mutex = new Mutex( false, typeof( UI_MainWindow ).ToString() ) ) {
				if( mutex.WaitOne( 0, false ) == false ) {
					MessageBox.Show(
						"[Clenaer] instance is already running.",
						"Error",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error );
					return;
				}
				ApplicationConfiguration.Initialize();
				Application.Run( new UI_MainWindow() );
			}
		}
	}
}