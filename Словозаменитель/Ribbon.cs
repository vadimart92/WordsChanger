using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using templateProcessorLib;

namespace Словозаменитель {
	public partial class Ribbon {
		private void Ribbon_Load(object sender, RibbonUIEventArgs e) {
			replaceBtn.Enabled = Globals.ThisAddIn.mappingDoc != null;
		}

		private void optionsBtn_Click(object sender, RibbonControlEventArgs e) {
			MapEditor editor = new MapEditor();
			if (editor.ShowDialog(Utils.LoadFilePath()) == System.Windows.Forms.DialogResult.OK) {
				var doc = Utils.TryReadXml();
				if (doc != null) {
					replaceBtn.Enabled = true;
					Globals.ThisAddIn.mappingDoc = doc;
				}
			}
		}

		private void replaceBtn_Click(object sender, RibbonControlEventArgs e) {
			Globals.ThisAddIn.DoReplaceLogic();
		}
	}
}
