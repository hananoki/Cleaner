using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cleaner.Properties;

namespace Cleaner {
	public partial class UC_SideBar : UserControl {
		public UC_SideBar() {
			InitializeComponent();

			if( UI_MainWindow.instance == null ) return;

			UI_MainWindow.instance.changeCulture += () => {
				button_temp.Text = Resources.DeleteTemporaryFiles;
				button_trash.Text = Resources.EmptytheTrash;
			};
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		async void OnClick( object sender, EventArgs e ) {
			var func = new Func<long>[]{
				CommandRecycleBin.Execute,
				CommandTemporary.Execute,
				CommandCSharp.Execute,
				CommandUnrealEngine.Execute,
				CommandUnity.Execute,
				};

			var button = sender as ToolStripItem;

			if( button == null ) return;

			using( var scope = new CommandScopeOp() ) {
				await Task.Run( () => {
					scope.totalSize = func[ (int) (ECommandType) button.Tag ]();
				} );
			}
		}


		void button_unity_DropDownOpening( object sender, EventArgs e ) {
			Console.WriteLine( "DropDownOpening" );
		}
	}
}
