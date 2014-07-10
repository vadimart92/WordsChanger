using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using templateProcessorLib;
using Microsoft.Office.Interop.Word;

namespace Словозаменитель
{
    public partial class ThisAddIn
    {
		public XDocument mappingDoc;
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
			var doc = Utils.TryReadXml();
			if (doc != null) {
				mappingDoc = doc;
			}
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {

        }
		public void DoReplaceLogic() {
			foreach (XElement item in mappingDoc.GetMappings()) {
				WordReplace(item.FirstAttribute.Value, item.LastAttribute.Value);
			}
		}
		private void WordReplace(string findString, string setString) {
			Word.Find findObject = Application.ActiveDocument.Range().Find;
			findObject.ClearFormatting();
			findObject.Text = findString;
			findObject.Replacement.ClearFormatting();
			findObject.Replacement.Text = setString;
			findObject.MatchWholeWord = false;
			findObject.MatchCase = false;

			object replaceAll = Word.WdReplace.wdReplaceAll;
			findObject.Execute(Replace:	ref replaceAll);
		}

        #region Код, автоматически созданный VSTO

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
