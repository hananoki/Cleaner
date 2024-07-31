using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsLib;
using Cleaner.Properties;


namespace Cleaner {
	public partial class UI_MainWindow : Form {

		public static UI_MainWindow instance;

		public event Action changeCulture;

		public event Action onLoad;

		/// <summary>
		/// 
		/// </summary>
		public UI_MainWindow() {
			instance = this;
			InitializeComponent();

			changeCulture += () => {
				toolStripButton1.Text = Resources.Cleaning;
				toolStripButton2.Text = Resources.Settings;
			};
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
		/// 
		/// </summary>
		/// <param name="lang"></param>
		public void EmitChangeCulture( string lang = "" ) {
			switch( lang ) {
				case "ja-JP":
					Thread.CurrentThread.CurrentUICulture = new CultureInfo( "ja-JP" );
					break;
				default:
					Thread.CurrentThread.CurrentUICulture = new CultureInfo( "" );
					break;
			}
			changeCulture?.Invoke();
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

			ChangePanel( EPanelType.Main );

			onLoad?.Invoke();

			Helper.ApplyLanguage();

			UC_StatusBar.Info( Resources.Started );
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


		/// <summary>
		/// コントロールにフォーカスがあるときにキーが押されると発生します
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OnKeyDown( object sender, KeyEventArgs e ) {
#if DEBUG
			if( e.KeyCode == Keys.F12 ) {
				if( UserSettings.instance.debugConsole ) {
					UserSettings.instance.debugConsole = false;
				}
				else {
					UserSettings.instance.debugConsole = true;
				}
				Helper.SelectConsoleWindow( UserSettings.instance.debugConsole );
			}
#endif
			//if( e.KeyCode == Keys.F11 ) {
			//	Helper.ApplyLanguage();
			//	UC_StatusBar.Info( Resources.ApplyLanguage );
			//}
			//if( e.KeyCode == Keys.F10 ) {
			//	UserSettings.instance.developMode = !UserSettings.instance.developMode;
			//	UC_StatusBar.Info( Resources.SwitchedDevelopMode );
			//}
		}


		void toolStripButton1_Click( object sender, EventArgs e ) {
			ChangePanel( EPanelType.Main );
		}

		void toolStripButton2_Click( object sender, EventArgs e ) {
			ChangePanel( EPanelType.Settings );
		}


		void toolStripButton3_Click( object sender, EventArgs e ) {

		}
	}
}

