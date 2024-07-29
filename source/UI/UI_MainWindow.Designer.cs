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
			button1 = new Button();
			panel_buttons = new Panel();
			button4 = new Button();
			button5 = new Button();
			button3 = new Button();
			button2 = new Button();
			toolStrip1 = new ToolStrip();
			toolStripButton1 = new ToolStripButton();
			toolStripButton2 = new ToolStripButton();
			panel_main = new Panel();
			uc_logListView = new UC_LogListView();
			panel1 = new Panel();
			imageList1 = new ImageList( components );
			uc_statusBar = new UC_StatusBar();
			panel_settings.SuspendLayout();
			panel_buttons.SuspendLayout();
			toolStrip1.SuspendLayout();
			panel_main.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel_settings
			// 
			panel_settings.Controls.Add( uc_settingProperty );
			panel_settings.Dock = DockStyle.Fill;
			panel_settings.Location = new Point( 0, 0 );
			panel_settings.Margin = new Padding( 0 );
			panel_settings.Name = "panel_settings";
			panel_settings.Padding = new Padding( 4 );
			panel_settings.Size = new Size( 485, 263 );
			panel_settings.TabIndex = 0;
			// 
			// uc_settingProperty
			// 
			uc_settingProperty.Dock = DockStyle.Fill;
			uc_settingProperty.Location = new Point( 4, 4 );
			uc_settingProperty.Margin = new Padding( 0 );
			uc_settingProperty.Name = "uc_settingProperty";
			uc_settingProperty.Size = new Size( 477, 255 );
			uc_settingProperty.TabIndex = 3;
			// 
			// button1
			// 
			button1.Dock = DockStyle.Top;
			button1.Image = (Image) resources.GetObject( "button1.Image" );
			button1.Location = new Point( 4, 4 );
			button1.Name = "button1";
			button1.Size = new Size( 150, 23 );
			button1.TabIndex = 0;
			button1.Text = "Delete Temporary Files";
			button1.TextImageRelation = TextImageRelation.ImageBeforeText;
			button1.UseVisualStyleBackColor = true;
			// 
			// panel_buttons
			// 
			panel_buttons.Controls.Add( button4 );
			panel_buttons.Controls.Add( button5 );
			panel_buttons.Controls.Add( button3 );
			panel_buttons.Controls.Add( button2 );
			panel_buttons.Controls.Add( button1 );
			panel_buttons.Dock = DockStyle.Left;
			panel_buttons.Location = new Point( 0, 0 );
			panel_buttons.Name = "panel_buttons";
			panel_buttons.Padding = new Padding( 4, 4, 2, 4 );
			panel_buttons.Size = new Size( 156, 263 );
			panel_buttons.TabIndex = 2;
			// 
			// button4
			// 
			button4.Dock = DockStyle.Top;
			button4.Image = (Image) resources.GetObject( "button4.Image" );
			button4.Location = new Point( 4, 96 );
			button4.Name = "button4";
			button4.Size = new Size( 150, 23 );
			button4.TabIndex = 3;
			button4.Text = "C# Object File";
			button4.TextImageRelation = TextImageRelation.ImageBeforeText;
			button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			button5.Dock = DockStyle.Top;
			button5.Location = new Point( 4, 73 );
			button5.Name = "button5";
			button5.Size = new Size( 150, 23 );
			button5.TabIndex = 4;
			button5.Text = "Unity";
			button5.TextImageRelation = TextImageRelation.ImageBeforeText;
			button5.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Dock = DockStyle.Top;
			button3.Image = (Image) resources.GetObject( "button3.Image" );
			button3.Location = new Point( 4, 50 );
			button3.Name = "button3";
			button3.Size = new Size( 150, 23 );
			button3.TabIndex = 2;
			button3.Text = "UnrealEngine";
			button3.TextAlign = ContentAlignment.BottomLeft;
			button3.TextImageRelation = TextImageRelation.ImageBeforeText;
			button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Dock = DockStyle.Top;
			button2.Image = (Image) resources.GetObject( "button2.Image" );
			button2.Location = new Point( 4, 27 );
			button2.Name = "button2";
			button2.Size = new Size( 150, 23 );
			button2.TabIndex = 1;
			button2.Text = "Empty The Trash";
			button2.TextImageRelation = TextImageRelation.ImageBeforeText;
			button2.UseVisualStyleBackColor = true;
			// 
			// toolStrip1
			// 
			toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			toolStrip1.Items.AddRange( new ToolStripItem[] { toolStripButton1, toolStripButton2 } );
			toolStrip1.Location = new Point( 0, 0 );
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Padding = new Padding( 4, 2, 4, 2 );
			toolStrip1.RenderMode = ToolStripRenderMode.Professional;
			toolStrip1.Size = new Size( 485, 39 );
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
			panel_main.Controls.Add( panel_buttons );
			panel_main.Dock = DockStyle.Fill;
			panel_main.Location = new Point( 0, 0 );
			panel_main.Name = "panel_main";
			panel_main.Size = new Size( 485, 263 );
			panel_main.TabIndex = 4;
			// 
			// uc_logListView
			// 
			uc_logListView.Dock = DockStyle.Fill;
			uc_logListView.Location = new Point( 156, 0 );
			uc_logListView.Name = "uc_logListView";
			uc_logListView.Padding = new Padding( 0, 0, 4, 2 );
			uc_logListView.Size = new Size( 329, 263 );
			uc_logListView.TabIndex = 3;
			// 
			// panel1
			// 
			panel1.Controls.Add( panel_main );
			panel1.Controls.Add( panel_settings );
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point( 0, 39 );
			panel1.Margin = new Padding( 0 );
			panel1.Name = "panel1";
			panel1.Size = new Size( 485, 263 );
			panel1.TabIndex = 5;
			// 
			// imageList1
			// 
			imageList1.ColorDepth = ColorDepth.Depth32Bit;
			imageList1.ImageStream = (ImageListStreamer) resources.GetObject( "imageList1.ImageStream" );
			imageList1.TransparentColor = Color.Transparent;
			imageList1.Images.SetKeyName( 0, "CSFile_16x.png" );
			imageList1.Images.SetKeyName( 1, "UnrealEd_icon.png" );
			// 
			// uc_statusBar
			// 
			uc_statusBar.AutoSize = true;
			uc_statusBar.Dock = DockStyle.Bottom;
			uc_statusBar.Location = new Point( 0, 302 );
			uc_statusBar.Name = "uc_statusBar";
			uc_statusBar.Size = new Size( 485, 22 );
			uc_statusBar.TabIndex = 6;
			// 
			// UI_MainWindow
			// 
			AutoScaleDimensions = new SizeF( 7F, 15F );
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size( 485, 324 );
			Controls.Add( panel1 );
			Controls.Add( uc_statusBar );
			Controls.Add( toolStrip1 );
			Icon = (Icon) resources.GetObject( "$this.Icon" );
			Name = "UI_MainWindow";
			Text = "Cleaner";
			FormClosing +=  OnFormClosing ;
			FormClosed +=  OnFormClosed ;
			Load +=  OnLoad ;
			panel_settings.ResumeLayout( false );
			panel_buttons.ResumeLayout( false );
			toolStrip1.ResumeLayout( false );
			toolStrip1.PerformLayout();
			panel_main.ResumeLayout( false );
			panel1.ResumeLayout( false );
			ResumeLayout( false );
			PerformLayout();
		}

		#endregion

		private Panel panel_settings;
		private Button button1;
		
		public Panel panel_buttons;
		private Button button2;
		private Button button3;
		private ToolStrip toolStrip1;
		private ToolStripButton toolStripButton1;
		private ToolStripButton toolStripButton2;
		
		private Panel panel_main;
		private Panel panel1;
		
		private Button button4;
		private Button button5;
		
		public ImageList imageList1;
		public UC_SettingProperty uc_settingProperty;
		public UC_LogListView uc_logListView;
		private UC_StatusBar uc_statusBar;
	}
}
