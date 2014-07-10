namespace Словозаменитель {
	partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase {
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public Ribbon()
			: base(Globals.Factory.GetRibbonFactory()) {
			InitializeComponent();
		}

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.tab1 = this.Factory.CreateRibbonTab();
			this.templateProcessorgroup = this.Factory.CreateRibbonGroup();
			this.optionsBtn = this.Factory.CreateRibbonButton();
			this.replaceBtn = this.Factory.CreateRibbonButton();
			this.tab1.SuspendLayout();
			this.templateProcessorgroup.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tab1.Groups.Add(this.templateProcessorgroup);
			this.tab1.Label = "TabAddIns";
			this.tab1.Name = "tab1";
			// 
			// templateProcessorgroup
			// 
			this.templateProcessorgroup.Items.Add(this.optionsBtn);
			this.templateProcessorgroup.Items.Add(this.replaceBtn);
			this.templateProcessorgroup.Label = "Процессор шаблонов";
			this.templateProcessorgroup.Name = "templateProcessorgroup";
			// 
			// optionsBtn
			// 
			this.optionsBtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.optionsBtn.Image = global::Словозаменитель.Properties.Resources._1399072283_internt_web_technology_02;
			this.optionsBtn.Label = "Настройка шаблона";
			this.optionsBtn.Name = "optionsBtn";
			this.optionsBtn.ShowImage = true;
			this.optionsBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.optionsBtn_Click);
			// 
			// replaceBtn
			// 
			this.replaceBtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.replaceBtn.Enabled = false;
			this.replaceBtn.Image = global::Словозаменитель.Properties.Resources._1399072370_edit_find_replace;
			this.replaceBtn.Label = "Заменить";
			this.replaceBtn.Name = "replaceBtn";
			this.replaceBtn.ShowImage = true;
			this.replaceBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.replaceBtn_Click);
			// 
			// Ribbon
			// 
			this.Name = "Ribbon";
			this.RibbonType = "Microsoft.Word.Document";
			this.Tabs.Add(this.tab1);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
			this.tab1.ResumeLayout(false);
			this.tab1.PerformLayout();
			this.templateProcessorgroup.ResumeLayout(false);
			this.templateProcessorgroup.PerformLayout();

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup templateProcessorgroup;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton optionsBtn;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton replaceBtn;
	}

	partial class ThisRibbonCollection {
		internal Ribbon Ribbon {
			get {
				return this.GetRibbon<Ribbon>();
			}
		}
	}
}
