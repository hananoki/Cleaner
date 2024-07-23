using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner {
	internal class Helper {
		public static Image GetCommandImage( ECommandType commandType ) {

			var i = UI_MainWindow.instance;
			
			if(commandType == ECommandType.UnrealEngine) {
				return i.imageList1.Images[1];
			}
			return i.imageList1.Images[ 0 ];
		}
	}
}
