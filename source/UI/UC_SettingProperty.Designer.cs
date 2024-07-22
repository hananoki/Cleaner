namespace Cleaner {
	partial class UC_SettingProperty {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( UC_SettingProperty ) );
			listBox1 = new System.Windows.Forms.ListBox();
			label1 = new System.Windows.Forms.Label();
			panel1 = new System.Windows.Forms.Panel();
			panel2 = new System.Windows.Forms.Panel();
			button1 = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// listBox1
			// 
			listBox1.Dock = System.Windows.Forms.DockStyle.Top;
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new System.Drawing.Point( 4, 19 );
			listBox1.Name = "listBox1";
			listBox1.Size = new System.Drawing.Size( 403, 109 );
			listBox1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = System.Windows.Forms.DockStyle.Top;
			label1.Location = new System.Drawing.Point( 4, 4 );
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size( 92, 15 );
			label1.TabIndex = 1;
			label1.Text = "C#プロジェクトパス";
			// 
			// panel1
			// 
			panel1.Controls.Add( panel2 );
			panel1.Controls.Add( listBox1 );
			panel1.Controls.Add( label1 );
			panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			panel1.Location = new System.Drawing.Point( 0, 0 );
			panel1.Name = "panel1";
			panel1.Padding = new System.Windows.Forms.Padding( 4 );
			panel1.Size = new System.Drawing.Size( 411, 340 );
			panel1.TabIndex = 2;
			// 
			// panel2
			// 
			panel2.Controls.Add( button1 );
			panel2.Controls.Add( button2 );
			panel2.Dock = System.Windows.Forms.DockStyle.Top;
			panel2.Location = new System.Drawing.Point( 4, 128 );
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size( 403, 28 );
			panel2.TabIndex = 4;
			// 
			// button1
			// 
			button1.Dock = System.Windows.Forms.DockStyle.Right;
			button1.Image = (System.Drawing.Image) resources.GetObject( "button1.Image" );
			button1.Location = new System.Drawing.Point( 253, 0 );
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size( 75, 28 );
			button1.TabIndex = 2;
			button1.Text = "追加";
			button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			button1.UseVisualStyleBackColor = true;
			button1.Click +=  button1_Click ;
			// 
			// button2
			// 
			button2.Dock = System.Windows.Forms.DockStyle.Right;
			button2.Image = (System.Drawing.Image) resources.GetObject( "button2.Image" );
			button2.Location = new System.Drawing.Point( 328, 0 );
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size( 75, 28 );
			button2.TabIndex = 3;
			button2.Text = "削除";
			button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			button2.UseVisualStyleBackColor = true;
			// 
			// UC_SettingProperty
			// 
			AutoScaleDimensions = new System.Drawing.SizeF( 7F, 15F );
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			Controls.Add( panel1 );
			Name = "UC_SettingProperty";
			Size = new System.Drawing.Size( 411, 340 );
			VisibleChanged +=  OnVisibleChanged ;
			panel1.ResumeLayout( false );
			panel1.PerformLayout();
			panel2.ResumeLayout( false );
			ResumeLayout( false );
		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}
