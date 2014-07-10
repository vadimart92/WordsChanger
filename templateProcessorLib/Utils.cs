using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Xml.Linq;

namespace templateProcessorLib
{
    public static class Utils
    {
		public const string RegistryKeyName = "WordReplaceSoftware";
		public const string ValueName = "mappingFilePath";
		public const string NodeName = "mappings";
		public static string LoadFilePath() {
			RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32);
			var myKey = key.OpenSubKey("Software").OpenSubKey(RegistryKeyName, true);
			if (myKey == null){
				myKey = key.CreateSubKey(RegistryKeyName);
			}
			var value = myKey.GetValue(ValueName, null);
			return (string)value;
		}
		public static void SaveFilePath(string path) {
			RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32);
			var myKey = key.OpenSubKey("Software").OpenSubKey(RegistryKeyName, true);
			if (myKey == null) {
				myKey = key.CreateSubKey(RegistryKeyName);
			}
			myKey.SetValue(ValueName, path);
		}
		public static void DeleteFilePath(string path) {
			RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32);
			var myKey = key.OpenSubKey("Software").OpenSubKey(RegistryKeyName, true);
			if (myKey == null) {
				myKey = key.CreateSubKey(RegistryKeyName);
			}
			myKey.DeleteValue(ValueName);
		}
		public static XDocument GenerateXml(this ListView.ListViewItemCollection collection) {
			var doc = new XDocument();
			var m = new XElement(NodeName);
			foreach (ListViewItem item in collection) {
				m.Add(item.Tag as XElement);
			}
			doc.Add(m);
			return doc;
		}
		public static void LoadXml(this ListView.ListViewItemCollection collection, string fileName) {
			var doc = XDocument.Load(fileName);
			foreach (XElement tag in doc.GetMappings()) {
				collection.Add(
					new ListViewItem(new[] { tag.FirstAttribute.Value, tag.LastAttribute.Value }) {
					Tag = tag
				});
			}
		}
		public static XDocument TryReadXml() {
			string file = LoadFilePath();
			if (!System.IO.File.Exists(file)) {
				return null;
			}
			return XDocument.Load(file);
		}
		public static IEnumerable<XElement> GetMappings(this XDocument doc) {
			return doc.Elements(NodeName).Descendants();
		}
    }
}
