namespace K40Controller
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
			this.consoleWindow = new System.Windows.Forms.RichTextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.graphPanel = new System.Windows.Forms.Panel();
			this.rulerControlY = new Lyquidity.UtilityLibrary.Controls.RulerControl();
			this.rulerControlX = new Lyquidity.UtilityLibrary.Controls.RulerControl();
			this.GCodeWindow = new System.Windows.Forms.RichTextBox();
			this.Test1 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.buttonConnect = new System.Windows.Forms.ToolStripButton();
			this.comboBoxConnect = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.originalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// consoleWindow
			// 
			this.consoleWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.consoleWindow.Location = new System.Drawing.Point(5, 33);
			this.consoleWindow.Name = "consoleWindow";
			this.consoleWindow.Size = new System.Drawing.Size(253, 562);
			this.consoleWindow.TabIndex = 0;
			this.consoleWindow.Text = "";
			this.consoleWindow.TextChanged += new System.EventHandler(this.consoleWindow_TextChanged);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(12, 56);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.Test1);
			this.splitContainer1.Panel2.Controls.Add(this.consoleWindow);
			this.splitContainer1.Size = new System.Drawing.Size(924, 600);
			this.splitContainer1.SplitterDistance = 662;
			this.splitContainer1.TabIndex = 1;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.graphPanel);
			this.splitContainer2.Panel1.Controls.Add(this.rulerControlY);
			this.splitContainer2.Panel1.Controls.Add(this.rulerControlX);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.GCodeWindow);
			this.splitContainer2.Size = new System.Drawing.Size(665, 600);
			this.splitContainer2.SplitterDistance = 451;
			this.splitContainer2.TabIndex = 2;
			// 
			// graphPanel
			// 
			this.graphPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.graphPanel.BackColor = System.Drawing.Color.Black;
			this.graphPanel.Location = new System.Drawing.Point(25, 25);
			this.graphPanel.Name = "graphPanel";
			this.graphPanel.Size = new System.Drawing.Size(637, 423);
			this.graphPanel.TabIndex = 0;
			this.graphPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.graphPanel_Paint);
			this.graphPanel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.graphPanel_MouseWheel);
			// 
			// rulerControlY
			// 
			this.rulerControlY.ActualSize = true;
			this.rulerControlY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.rulerControlY.DivisionMarkFactor = 5;
			this.rulerControlY.Divisions = 10;
			this.rulerControlY.ForeColor = System.Drawing.Color.Black;
			this.rulerControlY.Location = new System.Drawing.Point(0, 25);
			this.rulerControlY.MajorInterval = 100;
			this.rulerControlY.MiddleMarkFactor = 3;
			this.rulerControlY.MouseTrackingOn = false;
			this.rulerControlY.Name = "rulerControlY";
			this.rulerControlY.Orientation = Lyquidity.UtilityLibrary.Controls.enumOrientation.orVertical;
			this.rulerControlY.RulerAlignment = Lyquidity.UtilityLibrary.Controls.enumRulerAlignment.raBottomOrRight;
			this.rulerControlY.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smPoints;
			this.rulerControlY.Size = new System.Drawing.Size(26, 434);
			this.rulerControlY.StartValue = 0D;
			this.rulerControlY.TabIndex = 1;
			this.rulerControlY.Text = "rulerControlY";
			this.rulerControlY.VerticalNumbers = true;
			this.rulerControlY.ZoomFactor = 1D;
			// 
			// rulerControlX
			// 
			this.rulerControlX.ActualSize = true;
			this.rulerControlX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rulerControlX.DivisionMarkFactor = 5;
			this.rulerControlX.Divisions = 10;
			this.rulerControlX.ForeColor = System.Drawing.Color.Black;
			this.rulerControlX.Location = new System.Drawing.Point(25, 0);
			this.rulerControlX.MajorInterval = 100;
			this.rulerControlX.MiddleMarkFactor = 3;
			this.rulerControlX.MouseTrackingOn = false;
			this.rulerControlX.Name = "rulerControlX";
			this.rulerControlX.Orientation = Lyquidity.UtilityLibrary.Controls.enumOrientation.orHorizontal;
			this.rulerControlX.RulerAlignment = Lyquidity.UtilityLibrary.Controls.enumRulerAlignment.raBottomOrRight;
			this.rulerControlX.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smPoints;
			this.rulerControlX.Size = new System.Drawing.Size(640, 26);
			this.rulerControlX.StartValue = 0D;
			this.rulerControlX.TabIndex = 0;
			this.rulerControlX.Text = "rulerControlX";
			this.rulerControlX.VerticalNumbers = true;
			this.rulerControlX.ZoomFactor = 1D;
			// 
			// GCodeWindow
			// 
			this.GCodeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GCodeWindow.Location = new System.Drawing.Point(3, 3);
			this.GCodeWindow.Name = "GCodeWindow";
			this.GCodeWindow.Size = new System.Drawing.Size(662, 139);
			this.GCodeWindow.TabIndex = 0;
			this.GCodeWindow.Text = "";
			// 
			// Test1
			// 
			this.Test1.Location = new System.Drawing.Point(4, 4);
			this.Test1.Name = "Test1";
			this.Test1.Size = new System.Drawing.Size(75, 23);
			this.Test1.TabIndex = 1;
			this.Test1.Text = "Test";
			this.Test1.UseVisualStyleBackColor = true;
			this.Test1.Click += new System.EventHandler(this.Test1_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.pathToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(948, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.settingsToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// pathToolStripMenuItem
			// 
			this.pathToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupToolStripMenuItem,
            this.originalToolStripMenuItem});
			this.pathToolStripMenuItem.Name = "pathToolStripMenuItem";
			this.pathToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.pathToolStripMenuItem.Text = "Path";
			// 
			// groupToolStripMenuItem
			// 
			this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
			this.groupToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.groupToolStripMenuItem.Text = "Group";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton5,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.buttonConnect,
            this.comboBoxConnect});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(948, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "Open";
			this.toolStripButton1.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "Save";
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton4.Text = "Cut";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton3.Text = "Group";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// buttonConnect
			// 
			this.buttonConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonConnect.Image = ((System.Drawing.Image)(resources.GetObject("buttonConnect.Image")));
			this.buttonConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(23, 22);
			this.buttonConnect.Text = "Connect";
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// comboBoxConnect
			// 
			this.comboBoxConnect.Name = "comboBoxConnect";
			this.comboBoxConnect.Size = new System.Drawing.Size(121, 25);
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton5.Text = "Settings";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// originalToolStripMenuItem
			// 
			this.originalToolStripMenuItem.Name = "originalToolStripMenuItem";
			this.originalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.originalToolStripMenuItem.Text = "Original";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem1.Text = "About";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(948, 663);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "K40 Controller";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.RichTextBox consoleWindow;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel graphPanel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private Lyquidity.UtilityLibrary.Controls.RulerControl rulerControlY;
		private Lyquidity.UtilityLibrary.Controls.RulerControl rulerControlX;
		private System.Windows.Forms.Button Test1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.RichTextBox GCodeWindow;
		private System.Windows.Forms.ToolStripMenuItem pathToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton buttonConnect;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripComboBox comboBoxConnect;
		private System.Windows.Forms.ToolStripButton toolStripButton5;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem originalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

