using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cleaner {
	public partial class UC_SettingProperty : UserControl {
		public UC_SettingProperty() {
			InitializeComponent();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="form"></param>
		public void OnLoad() {
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnVisibleChanged( object sender, EventArgs e ) {
			try {
				if( Visible ) {
					//propertyGrid1.SelectedObject = UserSettings.instance;
					listBox1.Items.Clear();

					foreach( var s in UserSettings.instance.cs_project_paths ) {
						listBox1.Items.Add( s );
					}
				}
			}
			catch( Exception ex ) {
			}
		}

		void button1_Click( object sender, EventArgs e ) {
			using( var cofd = new CommonOpenFileDialog() ) {
				// フォルダを選択できるようにする
				cofd.IsFolderPicker = true;

				if( cofd.ShowDialog() == CommonFileDialogResult.Ok ) {
					// 何らかの処理
					var s = cofd.FileName;
					listBox1.Items.Add( s );
					UserSettings.instance.cs_project_paths.Add(s);
				}
			}
		}
	}
}
