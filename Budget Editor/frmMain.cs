using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;

namespace Budget_Editor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Notes
        /*
         * Started: 22 Dec 2018
         * Last Updated: 23 Dec 2018
         * 
         * TODO:
         * figure out how line number method works
         * file functions
         * icons
         * styles
         */
        #endregion

        #region Variables
        private Point _imageLocation = new Point(13, 5); //Used for drawing tabs
        private Point _imageHitArea = new Point(13, 2); //Used for drawing tabs
        private bool SavedAs;
        private bool Saved;
        #endregion

        #region Methods
        private void NewTab()
        {
            scintillaControl txtEditor = new scintillaControl();
            txtEditor.Dock = DockStyle.Fill;
            TabPage newTab = new TabPage("untitled.txt");
            newTab.Controls.Add(txtEditor);
            tabCtrl.TabPages.Add(newTab);
        }
        private void CloseTab(object sender, MouseEventArgs e)
        {
            TabControl tc = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.tabCtrl.GetTabRect(tc.SelectedIndex).Width - (_imageHitArea.X);
            Rectangle rect = this.tabCtrl.GetTabRect(tc.SelectedIndex);
            rect.Offset(_tabWidth, _imageHitArea.Y);
            rect.Width = 16;
            rect.Height = 16;
            if (tabCtrl.SelectedIndex >= 1)
            {
                if (rect.Contains(p))
                {
                    TabPage tabpage = (TabPage)tc.TabPages[tc.SelectedIndex];
                    tc.TabPages.Remove(tabpage);
                }
            }
            else if (tabCtrl.SelectedIndex == 0 && tabCtrl.TabPages.Count > 1)
            {
                if (rect.Contains(p))
                {
                    TabPage tabpage = (TabPage)tc.TabPages[tc.SelectedIndex];
                    tc.TabPages.Remove(tabpage);
                }
            }
            else
            {
                if (rect.Contains(p))
                {
                    Application.Exit();
                }
            }
        }
        private void DrawTab(object sender, DrawItemEventArgs e)
        {
            var tabPage = this.tabCtrl.TabPages[e.Index];
            var tabRect = this.tabCtrl.GetTabRect(e.Index);
            tabRect.Inflate(0, -2);

            var closeImage = Properties.Resources.CloseButton;
            e.Graphics.DrawImage(closeImage, (tabRect.Right - closeImage.Width), tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
            TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, tabRect, tabPage.ForeColor, TextFormatFlags.Left);
        }
        #endregion

        #region Events
        private void frmMain_Load(object sender, EventArgs e)
        {
            NewTab(); //Adds one new tab on open
        }
        private void tabCtrl_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawTab(sender, e);
        }
        private void tabCtrl_MouseDown(object sender, MouseEventArgs e)
        {
            CloseTab(sender, e);
        }

        #endregion

        #region File
        private void tsNew_Click(object sender, EventArgs e)
        {
            NewTab();
        }
        private void tsOpen_Click(object sender, EventArgs e)
        {

        }
        private void tsSave_Click(object sender, EventArgs e)
        {

        }
        private void tsSaveAs_Click(object sender, EventArgs e)
        {

        }
        private void tsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
