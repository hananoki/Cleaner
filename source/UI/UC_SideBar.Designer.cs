namespace Cleaner {
	partial class UC_SideBar {
		/// <summary> 
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose( bool disposing ) {
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region コンポーネント デザイナーで生成されたコード

		/// <summary> 
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( UC_SideBar ) );
			toolStrip2 = new System.Windows.Forms.ToolStrip();
			button_trash = new System.Windows.Forms.ToolStripButton();
			button_temp = new System.Windows.Forms.ToolStripButton();
			button_unreal = new System.Windows.Forms.ToolStripSplitButton();
			設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			button_unity = new System.Windows.Forms.ToolStripSplitButton();
			button_cs = new System.Windows.Forms.ToolStripSplitButton();
			toolStrip2.SuspendLayout();
			SuspendLayout();
			// 
			// toolStrip2
			// 
			toolStrip2.AutoSize = false;
			toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
			toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			toolStrip2.Items.AddRange( new System.Windows.Forms.ToolStripItem[] { button_trash, button_temp, button_unreal, button_unity, button_cs } );
			toolStrip2.Location = new System.Drawing.Point( 0, 0 );
			toolStrip2.Name = "toolStrip2";
			toolStrip2.Padding = new System.Windows.Forms.Padding( 4 );
			toolStrip2.Size = new System.Drawing.Size( 158, 355 );
			toolStrip2.TabIndex = 5;
			toolStrip2.Text = "toolStrip2";
			// 
			// button_trash
			// 
			button_trash.Image = (System.Drawing.Image) resources.GetObject( "button_trash.Image" );
			button_trash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			button_trash.ImageTransparentColor = System.Drawing.Color.Magenta;
			button_trash.Margin = new System.Windows.Forms.Padding( 0, 1, 0, 4 );
			button_trash.Name = "button_trash";
			button_trash.Size = new System.Drawing.Size( 149, 20 );
			button_trash.Tag = ECommandType.RecycleBin;
			button_trash.Text = "Empty The Trash";
			button_trash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			button_trash.Click +=  OnClick ;
			// 
			// button_temp
			// 
			button_temp.Image = (System.Drawing.Image) resources.GetObject( "button_temp.Image" );
			button_temp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			button_temp.ImageTransparentColor = System.Drawing.Color.Magenta;
			button_temp.Margin = new System.Windows.Forms.Padding( 0, 1, 0, 4 );
			button_temp.Name = "button_temp";
			button_temp.Size = new System.Drawing.Size( 149, 20 );
			button_temp.Tag = ECommandType.Temporary;
			button_temp.Text = "Delete Temporary Files";
			button_temp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			button_temp.Click +=  OnClick ;
			// 
			// button_unreal
			// 
			button_unreal.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] { 設定ToolStripMenuItem } );
			button_unreal.Image = (System.Drawing.Image) resources.GetObject( "button_unreal.Image" );
			button_unreal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			button_unreal.ImageTransparentColor = System.Drawing.Color.Magenta;
			button_unreal.Margin = new System.Windows.Forms.Padding( 0, 1, 0, 4 );
			button_unreal.Name = "button_unreal";
			button_unreal.Size = new System.Drawing.Size( 149, 20 );
			button_unreal.Tag = ECommandType.UnrealEngine;
			button_unreal.Text = "UnrealEngine";
			button_unreal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			button_unreal.ButtonClick +=  OnClick ;
			// 
			// 設定ToolStripMenuItem
			// 
			設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
			設定ToolStripMenuItem.Size = new System.Drawing.Size( 180, 22 );
			設定ToolStripMenuItem.Text = "設定";
			// 
			// button_unity
			// 
			button_unity.Image = (System.Drawing.Image) resources.GetObject( "button_unity.Image" );
			button_unity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			button_unity.ImageTransparentColor = System.Drawing.Color.Magenta;
			button_unity.Margin = new System.Windows.Forms.Padding( 0, 1, 0, 4 );
			button_unity.Name = "button_unity";
			button_unity.Size = new System.Drawing.Size( 149, 20 );
			button_unity.Tag = ECommandType.Unity;
			button_unity.Text = "Unity";
			button_unity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			button_unity.ButtonClick +=  OnClick ;
			button_unity.DropDownOpening +=  button_unity_DropDownOpening ;
			// 
			// button_cs
			// 
			button_cs.Image = (System.Drawing.Image) resources.GetObject( "button_cs.Image" );
			button_cs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			button_cs.ImageTransparentColor = System.Drawing.Color.Magenta;
			button_cs.Margin = new System.Windows.Forms.Padding( 0, 1, 0, 4 );
			button_cs.Name = "button_cs";
			button_cs.Size = new System.Drawing.Size( 149, 20 );
			button_cs.Tag = ECommandType.CSharp;
			button_cs.Text = "C#";
			button_cs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			button_cs.Click +=  OnClick ;
			// 
			// UC_SideBar
			// 
			AutoScaleDimensions = new System.Drawing.SizeF( 7F, 15F );
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			AutoSize = true;
			Controls.Add( toolStrip2 );
			Name = "UC_SideBar";
			Size = new System.Drawing.Size( 207, 355 );
			toolStrip2.ResumeLayout( false );
			toolStrip2.PerformLayout();
			ResumeLayout( false );
		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton button_temp;
		private System.Windows.Forms.ToolStripButton button_trash;
		private System.Windows.Forms.ToolStripSplitButton button_unreal;
		private System.Windows.Forms.ToolStripSplitButton button_unity;
		private System.Windows.Forms.ToolStripSplitButton button_cs;
		private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
	}
}
