using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsTimer = System.Windows.Forms.Timer;

namespace Cleaner {
	public partial class UC_StatusBar : UserControl {

		static UC_StatusBar instance;

		public WindowsFormsTimer m_timer;

		public UC_StatusBar() {
			instance = this;
			InitializeComponent();

			m_timer = new WindowsFormsTimer();
			m_timer.Tick += new EventHandler( ( s, ee ) => {
				Clear();
				m_timer.Stop();
			} );
		}

		public void SetMessage( string text = "", EStatusType type = EStatusType.Info, int interval = 5000 ) {
			toolStripStatusLabel1.Text = text;
			toolStripStatusLabel1.Image = imageList1.Images[ (int) type ];

			m_timer.Stop();
			if( 1 <= interval ) {
				m_timer.Interval = interval;
				m_timer.Start();
			}
		}

		public static void Clear() {
			UI_MainWindow.instance.Invoke( new Action( () => {
				instance.toolStripStatusLabel1.Text = "";
				instance.toolStripStatusLabel1.Image = null;
			} ) );
		}

		public static void Info( string text ) {
			UI_MainWindow.instance.Invoke( new Action( () => {
				instance.SetMessage( text, EStatusType.Info );
			} ) );
		}

		public static void Warning( string text ) {
			UI_MainWindow.instance.Invoke( new Action( () => {
				instance.SetMessage( text, EStatusType.Warning, 10000 );
			} ) );
		}

		public static void Error( string text ) {
			UI_MainWindow.instance.Invoke( new Action( () => {
				instance.SetMessage( text, EStatusType.Error, 10000 );
			} ) );
		}

		public static void Exception( Exception e ) {
			UI_MainWindow.instance.Invoke( new Action( () => {
				instance.SetMessage( e.Message, EStatusType.Error, 10000 );
			} ) );
			//Helper.InitConsole(true);
			//Console.WriteLine( e.ToString() );
		}

		private void toolStripStatusLabel1_Click( object sender, EventArgs e ) {
			Clipboard.SetText( toolStripStatusLabel1.Text );
		}
	}
}
