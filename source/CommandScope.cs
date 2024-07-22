using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner {
	public class CommandScope : IDisposable {

		public CommandScope() {
			Log.Clear();

			UI_MainWindow.instance.panel_buttons.Enabled = false;
		}

		public void Dispose() {
			Log.Info( "操作が完了しました" );
			var i = UI_MainWindow.instance;

			i.Invoke( new Action( () => {
				UI_MainWindow.instance.panel_buttons.Enabled = true;
			} ) );
		}
	}
}
