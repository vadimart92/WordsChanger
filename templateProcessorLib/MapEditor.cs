using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace templateProcessorLib {
	public partial class MapEditor : Form {

		private string filePath;
		public MapEditor() {
			InitializeComponent();
		}

		public DialogResult ShowDialog(string doc) {
			if (System.IO.File.Exists(doc)) {
				lv_mapEdit.Items.LoadXml(doc);
				btn_ok.Enabled = true;
				filePath = doc;
			} else {
				
			}
			return base.ShowDialog();
		}

		private void btn_open_Click(object sender, EventArgs e) {
			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				lv_mapEdit.Items.LoadXml(openFileDialog.FileName);
				btn_ok.Enabled = true;
				filePath = openFileDialog.FileName;
			}
		}

		private void toolStripButton1_Click(object sender, EventArgs e) {
			var tag = new XElement("map", new XAttribute("template", "{слово}"),
											new XAttribute("word", "Текст для замены"));
			lv_mapEdit.Items.Add(new ListViewItem(new[] { tag.FirstAttribute.Value, tag.LastAttribute.Value }) {
				Tag = tag
			});
			if (btn_ok.Enabled) {
				btn_ok.Enabled = false;
			}
		}

		private void btn_remove_Click(object sender, EventArgs e) {
			foreach (ListViewItem item in lv_mapEdit.SelectedItems)
			{
				lv_mapEdit.Items.Remove(item);
			}
			if (btn_ok.Enabled) {
				btn_ok.Enabled = false;
			}
		}

		private void btn_close_Click(object sender, EventArgs e) {
			if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK){
				lv_mapEdit.Items.GenerateXml().Save(saveFileDialog.FileName);
				btn_ok.Enabled = true;
				filePath = saveFileDialog.FileName;
			}
		}

		private void btn_ok_Click(object sender, EventArgs e) {
			Utils.SaveFilePath(filePath);
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}

		private void btn_cancel_Click(object sender, EventArgs e) {
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}

		private void tb_replace_TextChanged(object sender, EventArgs e) {
			saveRow(false);
		}

		private void tb_find_TextChanged(object sender, EventArgs e) {
			saveRow(true);
			
		}
		private void saveRow(bool template) {
			if (gb_edit.Tag == null) {
				return;
			}
			var item = gb_edit.Tag as ListViewItem;
			if (item == null) {
				return;
			}
			var xml = item.Tag as XElement;
			if (xml == null) {
				return;
			}
			if (template) {
				if (btn_ok.Enabled && !tb_find.Text.Equals(item.SubItems[0].Text)) {
					btn_ok.Enabled = false;
				}
				item.SubItems[0].Text = tb_find.Text;
				xml.FirstAttribute.Value = tb_find.Text;
			} else {
				if (btn_ok.Enabled && !tb_replace.Text.Equals(item.SubItems[1].Text)) {
					btn_ok.Enabled = false;
				}
				item.SubItems[1].Text = tb_replace.Text;
				xml.LastAttribute.Value = tb_replace.Text;
			}
		}

		private void MapEditor_Resize(object sender, EventArgs e) {
			tb_find.Width = gb_edit.Width - 10;
			tb_replace.Width = gb_edit.Width - 10;
		}

		private void lv_mapEdit_SelectedIndexChanged_1(object sender, EventArgs e) {
			if ( lv_mapEdit.SelectedIndices.Count < 1) {
				return;
			}
			var item = lv_mapEdit.Items[lv_mapEdit.SelectedIndices[0]];
			gb_edit.Tag = item;
			tb_find.Text = item.SubItems[0].Text;
			tb_replace.Text = item.SubItems[1].Text;
		}
	}
}
