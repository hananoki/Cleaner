using System.Drawing;
using System.Windows.Forms;

namespace Cleaner {
	partial class UI_MainWindow {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( UI_MainWindow ) );
			panel_settings = new Panel();
			uc_settingProperty = new UC_SettingProperty();
			toolStrip1 = new ToolStrip();
			toolStripButton1 = new ToolStripButton();
			toolStripButton2 = new ToolStripButton();
			panel_main = new Panel();
			uc_logListView = new UC_LogListView();
			uc_SideBar = new UC_SideBar();
			panel_root = new Panel();
			imageList1 = new ImageList( components );
			uc_statusBar = new UC_StatusBar();
			panel_settings.SuspendLayout();
			toolStrip1.SuspendLayout();
			panel_main.SuspendLayout();
			panel_root.SuspendLayout();
			SuspendLayout();
			// 
			// panel_settings
			// 
			panel_settings.Controls.Add( uc_settingProperty );
			panel_settings.Dock = DockStyle.Fill;
			panel_settings.Location = new Point( 0, 0 );
			panel_settings.Margin = new Padding( 0 );
			panel_settings.Name = "panel_settings";
			panel_settings.Size = new Size( 468, 281 );
			panel_settings.TabIndex = 0;
			// 
			// uc_settingProperty
			// 
			uc_settingProperty.Dock = DockStyle.Fill;
			uc_settingProperty.Location = new Point( 0, 0 );
			uc_settingProperty.Margin = new Padding( 0 );
			uc_settingProperty.Name = "uc_settingProperty";
			uc_settingProperty.Size = new Size( 468, 281 );
			uc_settingProperty.TabIndex = 3;
			// 
			// toolStrip1
			// 
			toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			toolStrip1.Items.AddRange( new ToolStripItem[] { toolStripButton1, toolStripButton2 } );
			toolStrip1.Location = new Point( 0, 0 );
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Padding = new Padding( 4, 2, 4, 2 );
			toolStrip1.RenderMode = ToolStripRenderMode.Professional;
			toolStrip1.Size = new Size( 468, 39 );
			toolStrip1.TabIndex = 3;
			toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			toolStripButton1.Image = (Image) resources.GetObject( "toolStripButton1.Image" );
			toolStripButton1.ImageTransparentColor = Color.Magenta;
			toolStripButton1.Margin = new Padding( 2, 0, 2, 0 );
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new Size( 40, 35 );
			toolStripButton1.Text = "Clean";
			toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton1.Click +=  toolStripButton1_Click ;
			// 
			// toolStripButton2
			// 
			toolStripButton2.Image = (Image) resources.GetObject( "toolStripButton2.Image" );
			toolStripButton2.ImageTransparentColor = Color.Magenta;
			toolStripButton2.Margin = new Padding( 2, 0, 2, 0 );
			toolStripButton2.Name = "toolStripButton2";
			toolStripButton2.Size = new Size( 53, 35 );
			toolStripButton2.Text = "Settings";
			toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton2.Click +=  toolStripButton2_Click ;
			// 
			// panel_main
			// 
			panel_main.Controls.Add( uc_logListView );
			panel_main.Controls.Add( uc_SideBar );
			panel_main.Dock = DockStyle.Fill;
			panel_main.Location = new Point( 0, 0 );
			panel_main.Name = "panel_main";
			panel_main.Size = new Size( 468, 281 );
			panel_main.TabIndex = 4;
			// 
			// uc_logListView
			// 
			uc_logListView.Dock = DockStyle.Fill;
			uc_logListView.Location = new Point( 158, 0 );
			uc_logListView.Name = "uc_logListView";
			uc_logListView.Padding = new Padding( 0, 0, 4, 2 );
			uc_logListView.Size = new Size( 310, 281 );
			uc_logListView.TabIndex = 3;
			// 
			// uc_SideBar
			// 
			uc_SideBar.AutoSize = true;
			uc_SideBar.Dock = DockStyle.Left;
			uc_SideBar.Location = new Point( 0, 0 );
			uc_SideBar.Name = "uc_SideBar";
			uc_SideBar.Size = new Size( 158, 281 );
			uc_SideBar.TabIndex = 5;
			// 
			// panel_root
			// 
			panel_root.Controls.Add( panel_main );
			panel_root.Controls.Add( panel_settings );
			panel_root.Dock = DockStyle.Fill;
			panel_root.Location = new Point( 0, 39 );
			panel_root.Margin = new Padding( 0 );
			panel_root.Name = "panel_root";
			panel_root.Size = new Size( 468, 281 );
			panel_root.TabIndex = 5;
			// 
			// imageList1
			// 
			imageList1.ColorDepth = ColorDepth.Depth32Bit;
			imageList1.ImageStream = (ImageListStreamer) resources.GetObject( "imageList1.ImageStream" );
			imageList1.TransparentColor = Color.Transparent;
			imageList1.Images.SetKeyName( 0, "CSFile_16x.png" );
			imageList1.Images.SetKeyName( 1, "UnrealEd_icon.png" );
			imageList1.Images.SetKeyName( 2, "unity-logo-light.png" );
			// 
			// uc_statusBar
			// 
			uc_statusBar.AutoSize = true;
			uc_statusBar.Dock = DockStyle.Bottom;
			uc_statusBar.Location = new Point( 0, 320 );
			uc_statusBar.Name = "uc_statusBar";
			uc_statusBar.Size = new Size( 468, 22 );
			uc_statusBar.TabIndex = 6;
			// 
			// UI_MainWindow
			// 
			AutoScaleDimensions = new SizeF( 7F, 15F );
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size( 468, 342 );
			Controls.Add( panel_root );
			Controls.Add( uc_statusBar );
			Controls.Add( toolStrip1 );
			Icon = (Icon) resources.GetObject( "$this.Icon" );
			KeyPreview = true;
			Name = "UI_MainWindow";
			Text = "Cleaner";
			FormClosing +=  OnFormClosing ;
			FormClosed +=  OnFormClosed ;
			Load +=  OnLoad ;
			KeyDown +=  OnKeyDown ;
			panel_settings.ResumeLayout( false );
			toolStrip1.ResumeLayout( false );
			toolStrip1.PerformLayout();
			panel_main.ResumeLayout( false );
			panel_main.PerformLayout();
			panel_root.ResumeLayout( false );
			ResumeLayout( false );
			PerformLayout();
		}

		#endregion

		private Panel panel_settings;
		private ToolStrip toolStrip1;
		private ToolStripButton toolStripButton1;
		private ToolStripButton toolStripButton2;
		
		private Panel panel_main;
		private Panel panel_root;
		
		public ImageList imageList1;
		public UC_SettingProperty uc_settingProperty;
		public UC_LogListView uc_logListView;
		private UC_StatusBar uc_statusBar;
		public UC_SideBar uc_SideBar;
	}
}
