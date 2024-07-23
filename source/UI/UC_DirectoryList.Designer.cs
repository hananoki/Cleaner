namespace Cleaner {
	partial class UC_DirectoryList {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( UC_DirectoryList ) );
			toolStrip1 = new System.Windows.Forms.ToolStrip();
			label = new System.Windows.Forms.ToolStripLabel();
			toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			listBox = new System.Windows.Forms.ListBox();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// toolStrip1
			// 
			toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
			toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			toolStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] { label, toolStripButton2, toolStripButton1 } );
			toolStrip1.Location = new System.Drawing.Point( 0, 0 );
			toolStrip1.Name = "toolStrip1";
			toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			toolStrip1.Size = new System.Drawing.Size( 341, 25 );
			toolStrip1.TabIndex = 7;
			toolStrip1.Text = "toolStrip1";
			// 
			// label
			// 
			label.Font = new System.Drawing.Font( "Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold );
			label.Name = "label";
			label.Size = new System.Drawing.Size( 32, 22 );
			label.Text = "label";
			// 
			// toolStripButton2
			// 
			toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			toolStripButton2.Image = (System.Drawing.Image) resources.GetObject( "toolStripButton2.Image" );
			toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			toolStripButton2.Name = "toolStripButton2";
			toolStripButton2.Size = new System.Drawing.Size( 60, 22 );
			toolStripButton2.Text = "Delete";
			toolStripButton2.Click +=  OnClick_Delete ;
			// 
			// toolStripButton1
			// 
			toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			toolStripButton1.Image = (System.Drawing.Image) resources.GetObject( "toolStripButton1.Image" );
			toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new System.Drawing.Size( 49, 22 );
			toolStripButton1.Text = "Add";
			toolStripButton1.Click +=  OnClick_Add ;
			// 
			// listBox
			// 
			listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			listBox.Dock = System.Windows.Forms.DockStyle.Fill;
			listBox.FormattingEnabled = true;
			listBox.ItemHeight = 15;
			listBox.Location = new System.Drawing.Point( 0, 25 );
			listBox.Name = "listBox";
			listBox.Size = new System.Drawing.Size( 341, 218 );
			listBox.TabIndex = 8;
			// 
			// UC_DirectoryList
			// 
			AutoScaleDimensions = new System.Drawing.SizeF( 7F, 15F );
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			AutoSize = true;
			Controls.Add( listBox );
			Controls.Add( toolStrip1 );
			Name = "UC_DirectoryList";
			Size = new System.Drawing.Size( 341, 243 );
			toolStrip1.ResumeLayout( false );
			toolStrip1.PerformLayout();
			ResumeLayout( false );
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel label;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ListBox listBox;
	}
}
