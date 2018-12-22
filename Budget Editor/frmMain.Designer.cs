namespace Budget_Editor
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mStrip = new System.Windows.Forms.MenuStrip();
            this.tsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFind = new System.Windows.Forms.ToolStripMenuItem();
            this.tsReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.tsZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFullscreen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsDocTree = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFont = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.iconBar = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.LineNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.mStrip.SuspendLayout();
            this.iconBar.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mStrip
            // 
            this.mStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFile,
            this.tsEdit,
            this.tsZoomIn,
            this.styleToolStripMenuItem,
            this.tsLanguage,
            this.tsHelp});
            this.mStrip.Location = new System.Drawing.Point(0, 0);
            this.mStrip.Name = "mStrip";
            this.mStrip.Size = new System.Drawing.Size(975, 24);
            this.mStrip.TabIndex = 0;
            this.mStrip.Text = "menuStrip1";
            // 
            // tsFile
            // 
            this.tsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNew,
            this.toolStripSeparator1,
            this.tsOpen,
            this.toolStripSeparator8,
            this.tsSave,
            this.tsSaveAs,
            this.toolStripSeparator2,
            this.tsExit});
            this.tsFile.Name = "tsFile";
            this.tsFile.Size = new System.Drawing.Size(37, 20);
            this.tsFile.Text = "File";
            // 
            // tsNew
            // 
            this.tsNew.Name = "tsNew";
            this.tsNew.Size = new System.Drawing.Size(114, 22);
            this.tsNew.Text = "New";
            this.tsNew.Click += new System.EventHandler(this.tsNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // tsOpen
            // 
            this.tsOpen.Name = "tsOpen";
            this.tsOpen.Size = new System.Drawing.Size(114, 22);
            this.tsOpen.Text = "Open";
            this.tsOpen.Click += new System.EventHandler(this.tsOpen_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(111, 6);
            // 
            // tsSave
            // 
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(114, 22);
            this.tsSave.Text = "Save";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // tsSaveAs
            // 
            this.tsSaveAs.Name = "tsSaveAs";
            this.tsSaveAs.Size = new System.Drawing.Size(114, 22);
            this.tsSaveAs.Text = "Save As";
            this.tsSaveAs.Click += new System.EventHandler(this.tsSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(111, 6);
            // 
            // tsExit
            // 
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(114, 22);
            this.tsExit.Text = "Exit";
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // tsEdit
            // 
            this.tsEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCut,
            this.tsCopy,
            this.tsPaste,
            this.toolStripSeparator3,
            this.tsFind,
            this.tsReplace});
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(39, 20);
            this.tsEdit.Text = "Edit";
            // 
            // tsCut
            // 
            this.tsCut.Name = "tsCut";
            this.tsCut.Size = new System.Drawing.Size(124, 22);
            this.tsCut.Text = "Cut";
            // 
            // tsCopy
            // 
            this.tsCopy.Name = "tsCopy";
            this.tsCopy.Size = new System.Drawing.Size(124, 22);
            this.tsCopy.Text = "Copy";
            // 
            // tsPaste
            // 
            this.tsPaste.Name = "tsPaste";
            this.tsPaste.Size = new System.Drawing.Size(124, 22);
            this.tsPaste.Text = "Paste";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(121, 6);
            // 
            // tsFind
            // 
            this.tsFind.Name = "tsFind";
            this.tsFind.Size = new System.Drawing.Size(124, 22);
            this.tsFind.Text = "Find...";
            // 
            // tsReplace
            // 
            this.tsReplace.Name = "tsReplace";
            this.tsReplace.Size = new System.Drawing.Size(124, 22);
            this.tsReplace.Text = "Replace...";
            // 
            // tsZoomIn
            // 
            this.tsZoomIn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.tsZoomOut,
            this.toolStripSeparator4,
            this.tsFullscreen,
            this.toolStripSeparator5,
            this.tsDocTree,
            this.tsStatusBar});
            this.tsZoomIn.Name = "tsZoomIn";
            this.tsZoomIn.Size = new System.Drawing.Size(44, 20);
            this.tsZoomIn.Text = "View";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            // 
            // tsZoomOut
            // 
            this.tsZoomOut.Name = "tsZoomOut";
            this.tsZoomOut.Size = new System.Drawing.Size(166, 22);
            this.tsZoomOut.Text = "Zoom Out";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(163, 6);
            // 
            // tsFullscreen
            // 
            this.tsFullscreen.Name = "tsFullscreen";
            this.tsFullscreen.Size = new System.Drawing.Size(166, 22);
            this.tsFullscreen.Text = "Toggle Fullscreen";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(163, 6);
            // 
            // tsDocTree
            // 
            this.tsDocTree.Name = "tsDocTree";
            this.tsDocTree.Size = new System.Drawing.Size(166, 22);
            this.tsDocTree.Text = "Document Tree";
            // 
            // tsStatusBar
            // 
            this.tsStatusBar.Name = "tsStatusBar";
            this.tsStatusBar.Size = new System.Drawing.Size(166, 22);
            this.tsStatusBar.Text = "Status Bar";
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFont,
            this.toolStripSeparator6,
            this.tsTheme,
            this.toolStripSeparator7,
            this.tsPreferences});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // tsFont
            // 
            this.tsFont.Name = "tsFont";
            this.tsFont.Size = new System.Drawing.Size(135, 22);
            this.tsFont.Text = "Font...";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(132, 6);
            // 
            // tsTheme
            // 
            this.tsTheme.Name = "tsTheme";
            this.tsTheme.Size = new System.Drawing.Size(135, 22);
            this.tsTheme.Text = "Theme...";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(132, 6);
            // 
            // tsPreferences
            // 
            this.tsPreferences.Name = "tsPreferences";
            this.tsPreferences.Size = new System.Drawing.Size(135, 22);
            this.tsPreferences.Text = "Preferences";
            // 
            // tsLanguage
            // 
            this.tsLanguage.Name = "tsLanguage";
            this.tsLanguage.Size = new System.Drawing.Size(71, 20);
            this.tsLanguage.Text = "Language";
            // 
            // tsHelp
            // 
            this.tsHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAbout});
            this.tsHelp.Name = "tsHelp";
            this.tsHelp.Size = new System.Drawing.Size(44, 20);
            this.tsHelp.Text = "Help";
            // 
            // tsAbout
            // 
            this.tsAbout.Name = "tsAbout";
            this.tsAbout.Size = new System.Drawing.Size(107, 22);
            this.tsAbout.Text = "About";
            // 
            // iconBar
            // 
            this.iconBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.iconBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.iconBar.Location = new System.Drawing.Point(0, 26);
            this.iconBar.Name = "iconBar";
            this.iconBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.iconBar.Size = new System.Drawing.Size(975, 25);
            this.iconBar.TabIndex = 1;
            this.iconBar.Text = "toolStrip1";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineNumber});
            this.statusStrip.Location = new System.Drawing.Point(0, 583);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip.Size = new System.Drawing.Size(975, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // LineNumber
            // 
            this.LineNumber.Name = "LineNumber";
            this.LineNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LineNumber.Size = new System.Drawing.Size(118, 17);
            this.LineNumber.Text = "toolStripStatusLabel1";
            // 
            // tabCtrl
            // 
            this.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabCtrl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrl.ItemSize = new System.Drawing.Size(50, 22);
            this.tabCtrl.Location = new System.Drawing.Point(0, 51);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.Padding = new System.Drawing.Point(10, 3);
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(975, 532);
            this.tabCtrl.TabIndex = 4;
            this.tabCtrl.TabStop = false;
            this.tabCtrl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabCtrl_DrawItem);
            this.tabCtrl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabCtrl_MouseDown);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(975, 2);
            this.label1.TabIndex = 5;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 605);
            this.Controls.Add(this.tabCtrl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.iconBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mStrip);
            this.MainMenuStrip = this.mStrip;
            this.Name = "frmMain";
            this.Text = "Budget Editor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mStrip.ResumeLayout(false);
            this.mStrip.PerformLayout();
            this.iconBar.ResumeLayout(false);
            this.iconBar.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mStrip;
        private System.Windows.Forms.ToolStripMenuItem tsFile;
        private System.Windows.Forms.ToolStripMenuItem tsNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsOpen;
        private System.Windows.Forms.ToolStripMenuItem tsSave;
        private System.Windows.Forms.ToolStripMenuItem tsSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsExit;
        private System.Windows.Forms.ToolStripMenuItem tsEdit;
        private System.Windows.Forms.ToolStripMenuItem tsCut;
        private System.Windows.Forms.ToolStripMenuItem tsCopy;
        private System.Windows.Forms.ToolStripMenuItem tsPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsFind;
        private System.Windows.Forms.ToolStripMenuItem tsReplace;
        private System.Windows.Forms.ToolStripMenuItem tsZoomIn;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsZoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsFullscreen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsDocTree;
        private System.Windows.Forms.ToolStripMenuItem tsStatusBar;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsTheme;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tsPreferences;
        private System.Windows.Forms.ToolStripMenuItem tsLanguage;
        private System.Windows.Forms.ToolStripMenuItem tsHelp;
        private System.Windows.Forms.ToolStripMenuItem tsAbout;
        private System.Windows.Forms.ToolStrip iconBar;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.ToolStripStatusLabel LineNumber;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

