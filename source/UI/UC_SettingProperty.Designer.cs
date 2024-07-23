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
			panel1 = new System.Windows.Forms.Panel();
			tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			uc_DirectoryList_UE = new UC_DirectoryList();
			uc_DirectoryList_CS = new UC_DirectoryList();
			panel1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add( tableLayoutPanel1 );
			panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			panel1.Location = new System.Drawing.Point( 0, 0 );
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size( 482, 333 );
			panel1.TabIndex = 2;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
			tableLayoutPanel1.Controls.Add( uc_DirectoryList_UE, 0, 1 );
			tableLayoutPanel1.Controls.Add( uc_DirectoryList_CS, 0, 0 );
			tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			tableLayoutPanel1.Location = new System.Drawing.Point( 0, 0 );
			tableLayoutPanel1.Margin = new System.Windows.Forms.Padding( 0 );
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
			tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
			tableLayoutPanel1.Size = new System.Drawing.Size( 482, 333 );
			tableLayoutPanel1.TabIndex = 10;
			// 
			// uc_DirectoryList_UE
			// 
			uc_DirectoryList_UE.AutoSize = true;
			uc_DirectoryList_UE.Dock = System.Windows.Forms.DockStyle.Fill;
			uc_DirectoryList_UE.Location = new System.Drawing.Point( 0, 166 );
			uc_DirectoryList_UE.Margin = new System.Windows.Forms.Padding( 0 );
			uc_DirectoryList_UE.Name = "uc_DirectoryList_UE";
			uc_DirectoryList_UE.Size = new System.Drawing.Size( 482, 167 );
			uc_DirectoryList_UE.TabIndex = 8;
			uc_DirectoryList_UE.Tag = ECommandType.UnrealEngine;
			// 
			// uc_DirectoryList_CS
			// 
			uc_DirectoryList_CS.AutoSize = true;
			uc_DirectoryList_CS.Dock = System.Windows.Forms.DockStyle.Fill;
			uc_DirectoryList_CS.Location = new System.Drawing.Point( 0, 0 );
			uc_DirectoryList_CS.Margin = new System.Windows.Forms.Padding( 0 );
			uc_DirectoryList_CS.Name = "uc_DirectoryList_CS";
			uc_DirectoryList_CS.Size = new System.Drawing.Size( 482, 166 );
			uc_DirectoryList_CS.TabIndex = 9;
			uc_DirectoryList_CS.Tag = ECommandType.CSharp;
			// 
			// UC_SettingProperty
			// 
			AutoScaleDimensions = new System.Drawing.SizeF( 7F, 15F );
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			Controls.Add( panel1 );
			Name = "UC_SettingProperty";
			Size = new System.Drawing.Size( 482, 333 );
			panel1.ResumeLayout( false );
			tableLayoutPanel1.ResumeLayout( false );
			tableLayoutPanel1.PerformLayout();
			ResumeLayout( false );
		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private UC_DirectoryList uc_DirectoryList_UE;
		private UC_DirectoryList uc_DirectoryList_CS;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
