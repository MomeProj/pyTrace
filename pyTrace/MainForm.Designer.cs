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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.pyTraceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sQLiteDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStripMain = new System.Windows.Forms.StatusStrip();
			this.toolStripContainerMain = new System.Windows.Forms.ToolStripContainer();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.toolStripPlayBack = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonPlay = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonPause = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
			this.toolStripMsgFilter = new System.Windows.Forms.ToolStrip();
			this.toolStripLabelCode = new System.Windows.Forms.ToolStripLabel();
			this.toolStripButtonMsgFilterEnable = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonAddFilter = new System.Windows.Forms.ToolStripButton();
			this.imageListPlayback = new System.Windows.Forms.ImageList(this.components);
			this.imageListFilter = new System.Windows.Forms.ImageList(this.components);
			this.toolStripComboBoxMsgFilter = new System.Windows.Forms.ToolStripComboBox();
			this.menuStripMain.SuspendLayout();
			this.toolStripContainerMain.ContentPanel.SuspendLayout();
			this.toolStripContainerMain.TopToolStripPanel.SuspendLayout();
			this.toolStripContainerMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.toolStripPlayBack.SuspendLayout();
			this.toolStripMsgFilter.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pyTraceToolStripMenuItem,
            this.optionsToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(344, 24);
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
			this.pyTraceToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F);
			this.pyTraceToolStripMenuItem.Name = "pyTraceToolStripMenuItem";
			this.pyTraceToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.pyTraceToolStripMenuItem.Text = "pyTrace";
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.loadToolStripMenuItem.Text = "Load";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQLiteDBToolStripMenuItem});
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.saveAsToolStripMenuItem.Text = "Save As ...";
			// 
			// sQLiteDBToolStripMenuItem
			// 
			this.sQLiteDBToolStripMenuItem.Name = "sQLiteDBToolStripMenuItem";
			this.sQLiteDBToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.sQLiteDBToolStripMenuItem.Text = "SQLite DB";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.ToolTipText = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F);
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.optionsToolStripMenuItem.Text = "Options";
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
			this.toolStripContainerMain.ContentPanel.Size = new System.Drawing.Size(344, 370);
			this.toolStripContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainerMain.LeftToolStripPanelVisible = false;
			this.toolStripContainerMain.Location = new System.Drawing.Point(0, 24);
			this.toolStripContainerMain.Name = "toolStripContainerMain";
			this.toolStripContainerMain.RightToolStripPanelVisible = false;
			this.toolStripContainerMain.Size = new System.Drawing.Size(344, 395);
			this.toolStripContainerMain.TabIndex = 2;
			this.toolStripContainerMain.Text = "toolStripContainer1";
			// 
			// toolStripContainerMain.TopToolStripPanel
			// 
			this.toolStripContainerMain.TopToolStripPanel.Controls.Add(this.toolStripPlayBack);
			this.toolStripContainerMain.TopToolStripPanel.Controls.Add(this.toolStripMsgFilter);
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
			this.dataGridView1.Size = new System.Drawing.Size(344, 370);
			this.dataGridView1.TabIndex = 0;
			// 
			// toolStripPlayBack
			// 
			this.toolStripPlayBack.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripPlayBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPlay,
            this.toolStripButtonPause,
            this.toolStripButtonStop});
			this.toolStripPlayBack.Location = new System.Drawing.Point(4, 0);
			this.toolStripPlayBack.Name = "toolStripPlayBack";
			this.toolStripPlayBack.Size = new System.Drawing.Size(81, 25);
			this.toolStripPlayBack.TabIndex = 0;
			// 
			// toolStripButtonPlay
			// 
			this.toolStripButtonPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPlay.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
			this.toolStripButtonPlay.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPlay.Image")));
			this.toolStripButtonPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonPlay.Name = "toolStripButtonPlay";
			this.toolStripButtonPlay.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonPlay.Text = "Play";
			this.toolStripButtonPlay.ToolTipText = "Play";
			this.toolStripButtonPlay.Click += new System.EventHandler(this.ToolStripButtonPlay_Click);
			this.toolStripButtonPlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStripButtonPlay_MouseDown);
			this.toolStripButtonPlay.MouseLeave += new System.EventHandler(this.ToolStripButtonPlay_MouseLeave);
			this.toolStripButtonPlay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ToolStripButtonPlay_MouseUp);
			// 
			// toolStripButtonPause
			// 
			this.toolStripButtonPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPause.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
			this.toolStripButtonPause.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPause.Image")));
			this.toolStripButtonPause.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonPause.Name = "toolStripButtonPause";
			this.toolStripButtonPause.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonPause.Text = "Pause";
			this.toolStripButtonPause.ToolTipText = "Pause";
			this.toolStripButtonPause.Click += new System.EventHandler(this.ToolStripButtonPause_Click);
			this.toolStripButtonPause.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStripButtonPause_MouseDown);
			this.toolStripButtonPause.MouseLeave += new System.EventHandler(this.ToolStripButtonPause_MouseLeave);
			this.toolStripButtonPause.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ToolStripButtonPause_MouseUp);
			// 
			// toolStripButtonStop
			// 
			this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonStop.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
			this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));
			this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonStop.Name = "toolStripButtonStop";
			this.toolStripButtonStop.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonStop.Text = "Stop";
			this.toolStripButtonStop.ToolTipText = "Stop";
			this.toolStripButtonStop.Click += new System.EventHandler(this.ToolStripButtonStop_Click);
			this.toolStripButtonStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStripButtonStop_MouseDown);
			this.toolStripButtonStop.MouseLeave += new System.EventHandler(this.ToolStripButtonStop_MouseLeave);
			this.toolStripButtonStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ToolStripButtonStop_MouseUp);
			// 
			// toolStripMsgFilter
			// 
			this.toolStripMsgFilter.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripMsgFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelCode,
            this.toolStripComboBoxMsgFilter,
            this.toolStripButtonMsgFilterEnable,
            this.toolStripButtonAddFilter});
			this.toolStripMsgFilter.Location = new System.Drawing.Point(87, 0);
			this.toolStripMsgFilter.Name = "toolStripMsgFilter";
			this.toolStripMsgFilter.Size = new System.Drawing.Size(252, 25);
			this.toolStripMsgFilter.TabIndex = 1;
			// 
			// toolStripLabelCode
			// 
			this.toolStripLabelCode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
			this.toolStripLabelCode.Name = "toolStripLabelCode";
			this.toolStripLabelCode.Size = new System.Drawing.Size(41, 22);
			this.toolStripLabelCode.Text = "Code:";
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
			// toolStripButtonAddFilter
			// 
			this.toolStripButtonAddFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonAddFilter.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
			this.toolStripButtonAddFilter.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddFilter.Image")));
			this.toolStripButtonAddFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAddFilter.Name = "toolStripButtonAddFilter";
			this.toolStripButtonAddFilter.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonAddFilter.Text = "Add Filter";
			this.toolStripButtonAddFilter.ToolTipText = "Add Filter";
			this.toolStripButtonAddFilter.Click += new System.EventHandler(this.ToolStripButtonAddFilter_Click);
			this.toolStripButtonAddFilter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStripButtonAddFilter_MouseDown);
			this.toolStripButtonAddFilter.MouseLeave += new System.EventHandler(this.ToolStripButtonAddFilter_MouseLeave);
			this.toolStripButtonAddFilter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ToolStripButtonAddFilter_MouseUp);
			// 
			// imageListPlayback
			// 
			this.imageListPlayback.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPlayback.ImageStream")));
			this.imageListPlayback.TransparentColor = System.Drawing.Color.Transparent;
			this.imageListPlayback.Images.SetKeyName(0, "play_16x16.png");
			this.imageListPlayback.Images.SetKeyName(1, "playp_16x16.png");
			this.imageListPlayback.Images.SetKeyName(2, "pause_16x16.png");
			this.imageListPlayback.Images.SetKeyName(3, "pausep_16x16.png");
			this.imageListPlayback.Images.SetKeyName(4, "stop_16x16.png");
			this.imageListPlayback.Images.SetKeyName(5, "stopp_16x16.png");
			// 
			// imageListFilter
			// 
			this.imageListFilter.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFilter.ImageStream")));
			this.imageListFilter.TransparentColor = System.Drawing.Color.Transparent;
			this.imageListFilter.Images.SetKeyName(0, "plus_16x16.png");
			this.imageListFilter.Images.SetKeyName(1, "plusp_16x16.png");
			// 
			// toolStripComboBoxMsgFilter
			// 
			this.toolStripComboBoxMsgFilter.Font = new System.Drawing.Font("Arial", 9F);
			this.toolStripComboBoxMsgFilter.Name = "toolStripComboBoxMsgFilter";
			this.toolStripComboBoxMsgFilter.Size = new System.Drawing.Size(120, 25);
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
			this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
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
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.toolStripPlayBack.ResumeLayout(false);
			this.toolStripPlayBack.PerformLayout();
			this.toolStripMsgFilter.ResumeLayout(false);
			this.toolStripMsgFilter.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStripMain;
		private System.Windows.Forms.ToolStripMenuItem pyTraceToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStripMain;
		private System.Windows.Forms.ToolStripContainer toolStripContainerMain;
		private System.Windows.Forms.ToolStrip toolStripPlayBack;
		private System.Windows.Forms.ToolStripButton toolStripButtonPlay;
		private System.Windows.Forms.ToolStripButton toolStripButtonPause;
		private System.Windows.Forms.ToolStripButton toolStripButtonStop;
		private System.Windows.Forms.ToolStrip toolStripMsgFilter;
		private System.Windows.Forms.ToolStripLabel toolStripLabelCode;
		private System.Windows.Forms.ToolStripButton toolStripButtonMsgFilterEnable;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripButtonAddFilter;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sQLiteDBToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ImageList imageListPlayback;
		private System.Windows.Forms.ImageList imageListFilter;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxMsgFilter;
	}
}

