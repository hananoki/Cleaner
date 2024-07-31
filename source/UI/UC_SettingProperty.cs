using Cleaner.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cleaner {
	public partial class UC_SettingProperty : UserControl {
		public UC_SettingProperty() {
			InitializeComponent();

			if( UI_MainWindow.instance == null ) return;

			UI_MainWindow.instance.onLoad += () => {
				uc_DirectoryList_CS.OnLoad(
					new DirectoryListData {
						image = Helper.GetCommandImage( uc_DirectoryList_CS.commandType ),
						name = "C# Project Path",
						addFunc = ( s ) => {
							if( UserSettings.instance.cs_project_paths.Contains( s ) ) {
								return false;
							}
							UserSettings.instance.cs_project_paths.Add( s );
							return true;
						},
						//deleteFunc = ( selectIndex ) => {
						//	UserSettings.instance.unreal_project_paths.RemoveAt( selectIndex );
						//	return true;
						//}
					} );

				uc_DirectoryList_Unity.OnLoad(
					new DirectoryListData {
						image = Helper.GetCommandImage( uc_DirectoryList_Unity.commandType ),
						name = "Unity",
						addFunc = ( s ) => {
							if( UserSettings.instance.unity_project_paths.Contains( s ) ) {
								return false;
							}
							UserSettings.instance.unity_project_paths.Add( s );
							return true;
						},
						//deleteFunc = ( selectIndex ) => {
						//	UserSettings.instance.unreal_project_paths.RemoveAt( selectIndex );
						//	return true;
						//}
					} );

				uc_DirectoryList_UE.OnLoad(
					new DirectoryListData {
						image = Helper.GetCommandImage( uc_DirectoryList_UE.commandType ),
						name = "Unreal Project Path",
						addFunc = ( s ) => {
							if( UserSettings.instance.unreal_project_paths.Contains( s ) ) {
								return false;
							}
							UserSettings.instance.unreal_project_paths.Add( s );
							return true;
						},
						deleteFunc = ( selectIndex ) => {
							UserSettings.instance.unreal_project_paths.RemoveAt( selectIndex );
							return true;
						}
					} );

				uc_DirectoryList_CS.SetListStrings( UserSettings.instance.cs_project_paths );
				uc_DirectoryList_UE.SetListStrings( UserSettings.instance.unreal_project_paths );
			};

			UI_MainWindow.instance.changeCulture += () => {
				uc_DirectoryList_CS.ApplyLanguage();
				uc_DirectoryList_UE.ApplyLanguage();
				uc_DirectoryList_Unity.ApplyLanguage();
			};
		}


	}
}
