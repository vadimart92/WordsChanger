namespace templateProcessorLib {
	partial class MapEditor {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_open = new System.Windows.Forms.ToolStripButton();
			this.btn_close = new System.Windows.Forms.ToolStripButton();
			this.btn_add = new System.Windows.Forms.ToolStripButton();
			this.btn_remove = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.lv_mapEdit = new System.Windows.Forms.ListView();
			this.map = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.word = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.gb_edit = new System.Windows.Forms.GroupBox();
			this.lbl_replace = new System.Windows.Forms.Label();
			this.lbl_find = new System.Windows.Forms.Label();
			this.tb_replace = new System.Windows.Forms.TextBox();
			this.tb_find = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btn_ok = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.toolStrip1.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.gb_edit.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_open,
            this.btn_close,
            this.btn_add,
            this.btn_remove});
			this.toolStrip1.Location = new System.Drawing.Point(3, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(124, 31);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btn_open
			// 
			this.btn_open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_open.Image = global::templateProcessorLib.Properties.Resources._1399072552_Open_file;
			this.btn_open.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_open.Name = "btn_open";
			this.btn_open.Size = new System.Drawing.Size(28, 28);
			this.btn_open.Text = "Открыть";
			this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
			// 
			// btn_close
			// 
			this.btn_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_close.Image = global::templateProcessorLib.Properties.Resources._1399072597_filesave;
			this.btn_close.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(28, 28);
			this.btn_close.Text = "Сохранить";
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// btn_add
			// 
			this.btn_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_add.Image = global::templateProcessorLib.Properties.Resources._1399076172_1;
			this.btn_add.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(28, 28);
			this.btn_add.Text = "+";
			this.btn_add.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// btn_remove
			// 
			this.btn_remove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_remove.Image = global::templateProcessorLib.Properties.Resources._1399076193_meanicons_24;
			this.btn_remove.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_remove.Name = "btn_remove";
			this.btn_remove.Size = new System.Drawing.Size(28, 28);
			this.btn_remove.Text = "-";
			this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.AutoScroll = true;
			this.toolStripContainer1.ContentPanel.Controls.Add(this.lv_mapEdit);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(610, 355);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(610, 386);
			this.toolStripContainer1.TabIndex = 2;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
			// 
			// lv_mapEdit
			// 
			this.lv_mapEdit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.map,
            this.word});
			this.lv_mapEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lv_mapEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lv_mapEdit.FullRowSelect = true;
			this.lv_mapEdit.Location = new System.Drawing.Point(0, 0);
			this.lv_mapEdit.Name = "lv_mapEdit";
			this.lv_mapEdit.Size = new System.Drawing.Size(610, 244);
			this.lv_mapEdit.TabIndex = 4;
			this.lv_mapEdit.UseCompatibleStateImageBehavior = false;
			this.lv_mapEdit.View = System.Windows.Forms.View.Details;
			this.lv_mapEdit.SelectedIndexChanged += new System.EventHandler(this.lv_mapEdit_SelectedIndexChanged_1);
			// 
			// map
			// 
			this.map.Text = "Шаблон";
			this.map.Width = 198;
			// 
			// word
			// 
			this.word.Text = "Заменить на";
			this.word.Width = 248;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 244);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(610, 111);
			this.panel1.TabIndex = 3;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Control;
			this.panel3.Controls.Add(this.gb_edit);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(510, 111);
			this.panel3.TabIndex = 3;
			// 
			// gb_edit
			// 
			this.gb_edit.Controls.Add(this.lbl_replace);
			this.gb_edit.Controls.Add(this.lbl_find);
			this.gb_edit.Controls.Add(this.tb_replace);
			this.gb_edit.Controls.Add(this.tb_find);
			this.gb_edit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_edit.Location = new System.Drawing.Point(0, 0);
			this.gb_edit.Name = "gb_edit";
			this.gb_edit.Size = new System.Drawing.Size(510, 111);
			this.gb_edit.TabIndex = 1;
			this.gb_edit.TabStop = false;
			this.gb_edit.Text = "Редактировать";
			// 
			// lbl_replace
			// 
			this.lbl_replace.AutoSize = true;
			this.lbl_replace.Location = new System.Drawing.Point(7, 60);
			this.lbl_replace.Name = "lbl_replace";
			this.lbl_replace.Size = new System.Drawing.Size(72, 13);
			this.lbl_replace.TabIndex = 1;
			this.lbl_replace.Text = "Заменить на";
			// 
			// lbl_find
			// 
			this.lbl_find.AutoSize = true;
			this.lbl_find.Location = new System.Drawing.Point(7, 16);
			this.lbl_find.Name = "lbl_find";
			this.lbl_find.Size = new System.Drawing.Size(38, 13);
			this.lbl_find.TabIndex = 1;
			this.lbl_find.Text = "Найти";
			// 
			// tb_replace
			// 
			this.tb_replace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_replace.Location = new System.Drawing.Point(6, 78);
			this.tb_replace.Name = "tb_replace";
			this.tb_replace.Size = new System.Drawing.Size(500, 22);
			this.tb_replace.TabIndex = 0;
			this.tb_replace.TextChanged += new System.EventHandler(this.tb_replace_TextChanged);
			// 
			// tb_find
			// 
			this.tb_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_find.Location = new System.Drawing.Point(6, 35);
			this.tb_find.Name = "tb_find";
			this.tb_find.Size = new System.Drawing.Size(500, 22);
			this.tb_find.TabIndex = 0;
			this.tb_find.TextChanged += new System.EventHandler(this.tb_find_TextChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btn_ok);
			this.panel2.Controls.Add(this.btn_cancel);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(510, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(100, 111);
			this.panel2.TabIndex = 2;
			// 
			// btn_ok
			// 
			this.btn_ok.Enabled = false;
			this.btn_ok.Location = new System.Drawing.Point(12, 69);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(75, 23);
			this.btn_ok.TabIndex = 2;
			this.btn_ok.Text = "OK";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.Location = new System.Drawing.Point(12, 34);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_cancel.TabIndex = 3;
			this.btn_cancel.Text = "Отмена";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.FileName = "шаблон замены";
			this.saveFileDialog.Filter = "Xml файлы|*.xml|Все файлы|*.*";
			this.saveFileDialog.RestoreDirectory = true;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "шаблон замены";
			this.openFileDialog.Filter = "Xml файлы|*.xml|Все файлы|*.*";
			// 
			// MapEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(610, 386);
			this.Controls.Add(this.toolStripContainer1);
			this.Name = "MapEditor";
			this.Text = "Редактировать замену";
			this.Resize += new System.EventHandler(this.MapEditor_Resize);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.gb_edit.ResumeLayout(false);
			this.gb_edit.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btn_open;
		private System.Windows.Forms.ToolStripButton btn_close;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStripButton btn_add;
		private System.Windows.Forms.ToolStripButton btn_remove;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.GroupBox gb_edit;
		private System.Windows.Forms.Label lbl_replace;
		private System.Windows.Forms.Label lbl_find;
		private System.Windows.Forms.TextBox tb_replace;
		private System.Windows.Forms.TextBox tb_find;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListView lv_mapEdit;
		private System.Windows.Forms.ColumnHeader map;
		private System.Windows.Forms.ColumnHeader word;
	}
}