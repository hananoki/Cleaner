namespace Cleaner {
	partial class UC_LogListView {
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
			listView = new System.Windows.Forms.ListView();
			columnHeader1 = new System.Windows.Forms.ColumnHeader();
			columnHeader2 = new System.Windows.Forms.ColumnHeader();
			SuspendLayout();
			// 
			// listView
			// 
			listView.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2 } );
			listView.Dock = System.Windows.Forms.DockStyle.Fill;
			listView.GridLines = true;
			listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			listView.Location = new System.Drawing.Point( 0, 0 );
			listView.Name = "listView";
			listView.Size = new System.Drawing.Size( 352, 316 );
			listView.TabIndex = 2;
			listView.UseCompatibleStateImageBehavior = false;
			listView.View = System.Windows.Forms.View.Details;
			listView.RetrieveVirtualItem +=  OnRetrieveVirtualItem ;
			listView.Resize +=  listView_Resize ;
			// 
			// UC_LogListView
			// 
			AutoScaleDimensions = new System.Drawing.SizeF( 7F, 15F );
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			Controls.Add( listView );
			Name = "UC_LogListView";
			Size = new System.Drawing.Size( 352, 316 );
			ResumeLayout( false );
		}

		#endregion

		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
	}
}
