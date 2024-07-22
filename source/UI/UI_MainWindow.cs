using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cleaner.Command;
using WinFormsLib;



namespace Cleaner
{
	public partial class UI_MainWindow : Form {

		public static UI_MainWindow instance;

		public UI_MainWindow() {
			instance = this;
			InitializeComponent();
		}


		/// <summary>
		/// 
		/// </summary>
		public void ChangePanel( EPanelType panelType ) {
			Control[] table = {
				panel_main,
				panel_settings,
			};
			ToolStripButton[] buttons = {
				toolStripButton1,
				toolStripButton2,
			};

			foreach( var e in EnumUtils.GetArray<EPanelType>() ) {
				table[ (int) e ].Visible = e == panelType;
				buttons[ (int) e ].CheckState = e == panelType ? CheckState.Checked : CheckState.Unchecked;
			}
		}


		/// <summary>
		/// フォームが初めて表示される直前に発生します。
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OnLoad( object sender, EventArgs e ) {
			Font = SystemFonts.IconTitleFont;

			UserSettings.Load();
			UserSettings.RollbackWindow( this );

			uc_logListView.OnLoad( this );

			button1.Click += CommandRecycleBin.Execute;
			button2.Click += CommandTemporary.Execute;
			button3.Click += CommandUnrealEngine.Execute;
			button4.Click += CommandCSharp.Execute;
			button5.Click += CommandUnity.Execute;

			ChangePanel( EPanelType.Main );
		}


		/// <summary>
		/// フォームが閉じる前に発生します
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OnFormClosing( object sender, FormClosingEventArgs e ) {
			UserSettings.BackupWindow( this );
		}


		/// <summary>
		/// フォームが閉じた後に発生します
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OnFormClosed( object sender, FormClosedEventArgs e ) {
			UserSettings.Save();
		}



		void toolStripButton1_Click( object sender, EventArgs e ) {
			ChangePanel( EPanelType.Main );
		}

		void toolStripButton2_Click( object sender, EventArgs e ) {
			ChangePanel( EPanelType.Settings );
		}

	}
}

