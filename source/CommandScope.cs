using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleaner.Properties;

namespace Cleaner {
	public class CommandScopeOp : IDisposable {

		long totalSize = 0;
		Func<long>[] funcs;

		public CommandScopeOp( Func<long>[] fn ) {
			Log.Clear();

			//var i = UI_MainWindow.instance;

			//i.Invoke( new Action( () => {
			UI_MainWindow.instance.panel_buttons.Enabled = false;
			//} ) );

			funcs = fn;
		}

		public void Execute() {
			foreach( var f in funcs ) {
				totalSize += f.Invoke();
			}
		}

		public void Dispose() {
			Log.Info( $"{Resources.TotaSizeDeleted}: {FileUtils.MB( totalSize )}" );
			Log.Info( Resources.OperationCompleted );
			UC_StatusBar.Info( Resources.OperationCompleted );

			var i = UI_MainWindow.instance;

			i.Invoke( new Action( () => {
				UI_MainWindow.instance.panel_buttons.Enabled = true;
			} ) );
		}
	}


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
