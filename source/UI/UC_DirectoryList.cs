using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using Cleaner.Properties;

namespace Cleaner {
	public partial class UC_DirectoryList : UserControl {

		public ECommandType commandType => (ECommandType) Tag;
		DirectoryListData directoryListData;


		/// <summary>
		/// 
		/// </summary>
		public UC_DirectoryList() {
			InitializeComponent();
		}

		public void ApplyLanguage() {
			toolStripButton1.Text = Resources.Add;
			toolStripButton2.Text = Resources.Delete;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="directoryListData"></param>
		public void OnLoad( DirectoryListData directoryListData ) {
			this.directoryListData = directoryListData;

			label.Image = directoryListData.image;
			label.Text = directoryListData.name;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="str"></param>
		public void SetListStrings( string[] str ) {
			listBox.Items.Clear();
			listBox.Items.AddRange( str );
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="str"></param>
		public void SetListStrings( List<string> str ) {
			SetListStrings( str.ToArray() );
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OnClick_Add( object sender, EventArgs e ) {

			using( var cofd = new CommonOpenFileDialog() ) {
				// フォルダを選択できるようにする
				cofd.IsFolderPicker = true;

				if( cofd.ShowDialog() == CommonFileDialogResult.Ok ) {

					if( directoryListData.addFunc( cofd.FileName ) ) {
						listBox.Items.Add( cofd.FileName );
						UserSettings.Save();
					}
				}
			}

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OnClick_Delete( object sender, EventArgs e ) {
			if( directoryListData.deleteFunc( listBox.SelectedIndex ) ) {
				listBox.Items.RemoveAt( listBox.SelectedIndex );
			}
		}
	}
}
