using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Cleaner {
	public class Log {
		public static void Clear() {
			var i = UI_MainWindow.instance;

			i.uc_logListView.Clear();
		}

		public static void Info( string text ) {
			var i = UI_MainWindow.instance;

			i.Invoke( new Action( () => {
				i.uc_logListView.Info( text );
			} ) );
		}

		public static void Error( string text ) {
			var i = UI_MainWindow.instance;

			i.Invoke( new Action( () => {
				i.uc_logListView.Error( text );
			} ) );
		}
	}
}
