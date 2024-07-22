using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsLib;

namespace Cleaner {
	public partial class UC_LogListView : UserControl {

		List<ListViewItem> m_fileItems = new();

		public UC_LogListView() {
			InitializeComponent();
		}

		public void Clear() {
			m_fileItems = new();
			listView.VirtualListSize = 0;
		}

		public void AddLog( string[] text ) {
			foreach( string item in text ) {
				Info( item );
			}
		}

		void SetText( string text, Color? color ) {
			const string format = "yyyy-MM-dd HH:mm:ss.fff";

			var newItem = new ListViewItem( new string[] {
					DateTime.Now.ToString( format ),
					text,
				} );
			
			if( color.HasValue ) {
				newItem.BackColor = color.Value;
			}

			m_fileItems.Add( newItem );

			listView.VirtualListSize = m_fileItems.Count;
		}

		public void Info( string text ) {
			SetText( text, Color.LightCyan );
		}

		public void Error( string text ) {
			SetText( text, Color.Pink );
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="form"></param>
		public void OnLoad( UI_MainWindow ui_MainWindow ) {
			listView.SetDoubleBuffered( true );
			listView.VirtualMode = true;
			ResizeColumns();
			//ui_MainWindow.changeCulture += ( lang ) => {

			//	listView.Columns[ 0 ].Text = Resources.VariableName;
			//	listView.Columns[ 1 ].Text = Resources.Path;
			//};
		}

		void ResizeColumns() {
			listView.Columns[ 0 ].Width = 140;
			listView.Columns[ 1 ].Width = listView.Width - 4 - listView.Columns[ 0 ].Width;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OnRetrieveVirtualItem( object sender, RetrieveVirtualItemEventArgs e ) {
			//var lstView = (ListView) sender;
			var items = m_fileItems;

			if( items.Count <= e.ItemIndex ) return;
			if( items == null ) return;

			e.Item = items[ e.ItemIndex ];
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void listView_Resize( object sender, EventArgs e ) {
			ResizeColumns();
		}
	}
}
