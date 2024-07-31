using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleaner.Properties;

namespace Cleaner {
	public class CommandScopeOp : IDisposable {

		public long totalSize = 0;

		public CommandScopeOp() {
			Log.Clear();
			UI_MainWindow.instance.uc_SideBar.Enabled = false;
		}

		public void Dispose() {
			Log.Info( $"{Resources.TotaSizeDeleted}: {FileUtils.MB( totalSize )}" );
			Log.Info( Resources.OperationCompleted );
			UC_StatusBar.Info( Resources.OperationCompleted );
			UI_MainWindow.instance.uc_SideBar.Enabled = true;
		}

	}
}
