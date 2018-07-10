namespace pyTrace
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.pyTraceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStripMain = new System.Windows.Forms.StatusStrip();
			this.toolStripContainerMain = new System.Windows.Forms.ToolStripContainer();
			this.toolStripPlayBack = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripMsgFilter = new System.Windows.Forms.ToolStrip();
			this.toolStripLabelCode = new System.Windows.Forms.ToolStripLabel();
			this.toolStripTextBoxMsgFilter = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButtonMsgFilterEnable = new System.Windows.Forms.ToolStripButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sQLiteDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStripMain.SuspendLayout();
			this.toolStripContainerMain.ContentPanel.SuspendLayout();
			this.toolStripContainerMain.TopToolStripPanel.SuspendLayout();
			this.toolStripContainerMain.SuspendLayout();
			this.toolStripPlayBack.SuspendLayout();
			this.toolStripMsgFilter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pyTraceToolStripMenuItem,
            this.optionsToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(344, 27);
			this.menuStripMain.TabIndex = 0;
			this.menuStripMain.Text = "menuStrip1";
			// 
			// pyTraceToolStripMenuItem
			// 
			this.pyTraceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.pyTraceToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
			this.pyTraceToolStripMenuItem.Name = "pyTraceToolStripMenuItem";
			this.pyTraceToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.pyTraceToolStripMenuItem.Text = "pyTrace";
			// 
			// statusStripMain
			// 
			this.statusStripMain.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
			this.statusStripMain.Location = new System.Drawing.Point(0, 419);
			this.statusStripMain.Name = "statusStripMain";
			this.statusStripMain.Size = new System.Drawing.Size(344, 22);
			this.statusStripMain.TabIndex = 1;
			this.statusStripMain.Text = "statusStrip1";
			// 
			// toolStripContainerMain
			// 
			this.toolStripContainerMain.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainerMain.ContentPanel
			// 
			this.toolStripContainerMain.ContentPanel.Controls.Add(this.dataGridView1);
			this.toolStripContainerMain.ContentPanel.Size = new System.Drawing.Size(344, 367);
			this.toolStripContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainerMain.LeftToolStripPanelVisible = false;
			this.toolStripContainerMain.Location = new System.Drawing.Point(0, 27);
			this.toolStripContainerMain.Name = "toolStripContainerMain";
			this.toolStripContainerMain.RightToolStripPanelVisible = false;
			this.toolStripContainerMain.Size = new System.Drawing.Size(344, 392);
			this.toolStripContainerMain.TabIndex = 2;
			this.toolStripContainerMain.Text = "toolStripContainer1";
			// 
			// toolStripContainerMain.TopToolStripPanel
			// 
			this.toolStripContainerMain.TopToolStripPanel.Controls.Add(this.toolStripPlayBack);
			this.toolStripContainerMain.TopToolStripPanel.Controls.Add(this.toolStripMsgFilter);
			// 
			// toolStripPlayBack
			// 
			this.toolStripPlayBack.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripPlayBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
			this.toolStripPlayBack.Location = new System.Drawing.Point(4, 0);
			this.toolStripPlayBack.Name = "toolStripPlayBack";
			this.toolStripPlayBack.Size = new System.Drawing.Size(81, 25);
			this.toolStripPlayBack.TabIndex = 0;
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButtonPlay";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "toolStripButtonPause";
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton3.Text = "toolStripButtonStop";
			// 
			// toolStripMsgFilter
			// 
			this.toolStripMsgFilter.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripMsgFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelCode,
            this.toolStripTextBoxMsgFilter,
            this.toolStripButtonMsgFilterEnable,
            this.toolStripButton4});
			this.toolStripMsgFilter.Location = new System.Drawing.Point(85, 0);
			this.toolStripMsgFilter.Name = "toolStripMsgFilter";
			this.toolStripMsgFilter.Size = new System.Drawing.Size(221, 25);
			this.toolStripMsgFilter.TabIndex = 1;
			// 
			// toolStripLabelCode
			// 
			this.toolStripLabelCode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
			this.toolStripLabelCode.Name = "toolStripLabelCode";
			this.toolStripLabelCode.Size = new System.Drawing.Size(41, 22);
			this.toolStripLabelCode.Text = "Code:";
			// 
			// toolStripTextBoxMsgFilter
			// 
			this.toolStripTextBoxMsgFilter.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
			this.toolStripTextBoxMsgFilter.Name = "toolStripTextBoxMsgFilter";
			this.toolStripTextBoxMsgFilter.Size = new System.Drawing.Size(120, 25);
			// 
			// toolStripButtonMsgFilterEnable
			// 
			this.toolStripButtonMsgFilterEnable.CheckOnClick = true;
			this.toolStripButtonMsgFilterEnable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonMsgFilterEnable.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
			this.toolStripButtonMsgFilterEnable.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMsgFilterEnable.Image")));
			this.toolStripButtonMsgFilterEnable.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonMsgFilterEnable.Name = "toolStripButtonMsgFilterEnable";
			this.toolStripButtonMsgFilterEnable.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonMsgFilterEnable.Text = "Enable";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(344, 367);
			this.dataGridView1.TabIndex = 0;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.ToolTipText = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton4.Text = "toolStripButtonAddFilter";
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.loadToolStripMenuItem.Text = "Load";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQLiteDBToolStripMenuItem});
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveAsToolStripMenuItem.Text = "Save As ...";
			// 
			// sQLiteDBToolStripMenuItem
			// 
			this.sQLiteDBToolStripMenuItem.Name = "sQLiteDBToolStripMenuItem";
			this.sQLiteDBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.sQLiteDBToolStripMenuItem.Text = "SQLite DB";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(76, 23);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(344, 441);
			this.Controls.Add(this.toolStripContainerMain);
			this.Controls.Add(this.statusStripMain);
			this.Controls.Add(this.menuStripMain);
			this.DoubleBuffered = true;
			this.MainMenuStrip = this.menuStripMain;
			this.Name = "MainForm";
			this.Text = "pyTrace";
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			this.toolStripContainerMain.ContentPanel.ResumeLayout(false);
			this.toolStripContainerMain.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainerMain.TopToolStripPanel.PerformLayout();
			this.toolStripContainerMain.ResumeLayout(false);
			this.toolStripContainerMain.PerformLayout();
			this.toolStripPlayBack.ResumeLayout(false);
			this.toolStripPlayBack.PerformLayout();
			this.toolStripMsgFilter.ResumeLayout(false);
			this.toolStripMsgFilter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStripMain;
		private System.Windows.Forms.ToolStripMenuItem pyTraceToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStripMain;
		private System.Windows.Forms.ToolStripContainer toolStripContainerMain;
		private System.Windows.Forms.ToolStrip toolStripPlayBack;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStrip toolStripMsgFilter;
		private System.Windows.Forms.ToolStripLabel toolStripLabelCode;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxMsgFilter;
		private System.Windows.Forms.ToolStripButton toolStripButtonMsgFilterEnable;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sQLiteDBToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
	}
}

