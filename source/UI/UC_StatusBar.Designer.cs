namespace Cleaner {
	partial class UC_StatusBar {
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( UC_StatusBar ) );
			panel1 = new System.Windows.Forms.Panel();
			statusStrip1 = new System.Windows.Forms.StatusStrip();
			toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			imageList1 = new System.Windows.Forms.ImageList( components );
			statusStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.AutoSize = true;
			panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			panel1.Location = new System.Drawing.Point( 0, 75 );
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size( 337, 0 );
			panel1.TabIndex = 0;
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1 } );
			statusStrip1.Location = new System.Drawing.Point( 0, 53 );
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new System.Drawing.Size( 337, 22 );
			statusStrip1.TabIndex = 1;
			statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new System.Drawing.Size( 118, 17 );
			toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			toolStripStatusLabel1.Click +=  toolStripStatusLabel1_Click ;
			// 
			// imageList1
			// 
			imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) resources.GetObject( "imageList1.ImageStream" );
			imageList1.TransparentColor = System.Drawing.Color.Transparent;
			imageList1.Images.SetKeyName( 0, "StatusInformation.png" );
			imageList1.Images.SetKeyName( 1, "StatusWarningOutline.png" );
			imageList1.Images.SetKeyName( 2, "StatusError.png" );
			// 
			// UC_StatusBar
			// 
			AutoScaleDimensions = new System.Drawing.SizeF( 7F, 15F );
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			AutoSize = true;
			Controls.Add( statusStrip1 );
			Controls.Add( panel1 );
			Name = "UC_StatusBar";
			Size = new System.Drawing.Size( 337, 75 );
			statusStrip1.ResumeLayout( false );
			statusStrip1.PerformLayout();
			ResumeLayout( false );
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ImageList imageList1;
	}
}
