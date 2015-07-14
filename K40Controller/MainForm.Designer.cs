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
			this.consoleWindow = new System.Windows.Forms.RichTextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.rulerControlY = new Lyquidity.UtilityLibrary.Controls.RulerControl();
			this.graphPanel = new System.Windows.Forms.Panel();
			this.rulerControlX = new Lyquidity.UtilityLibrary.Controls.RulerControl();
			this.Test1 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.listBoxConnect = new System.Windows.Forms.ListBox();
			this.buttonConnect = new System.Windows.Forms.Button();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.GCodeWindow = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
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
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(948, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(948, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// listBoxConnect
			// 
			this.listBoxConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxConnect.FormattingEnabled = true;
			this.listBoxConnect.Location = new System.Drawing.Point(781, 24);
			this.listBoxConnect.Name = "listBoxConnect";
			this.listBoxConnect.Size = new System.Drawing.Size(155, 17);
			this.listBoxConnect.TabIndex = 4;
			// 
			// buttonConnect
			// 
			this.buttonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonConnect.Location = new System.Drawing.Point(700, 24);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(75, 23);
			this.buttonConnect.TabIndex = 5;
			this.buttonConnect.Text = "Connect";
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// buttonPrint
			// 
			this.buttonPrint.Location = new System.Drawing.Point(12, 24);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(75, 23);
			this.buttonPrint.TabIndex = 6;
			this.buttonPrint.Text = "Print";
			this.buttonPrint.UseVisualStyleBackColor = true;
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(948, 663);
			this.Controls.Add(this.buttonPrint);
			this.Controls.Add(this.buttonConnect);
			this.Controls.Add(this.listBoxConnect);
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
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
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
		private System.Windows.Forms.ListBox listBoxConnect;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.Button buttonPrint;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.RichTextBox GCodeWindow;
    }
}

