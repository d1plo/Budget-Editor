using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;

namespace Budget_Editor
{
    public partial class scintillaControl : UserControl
    {
        private int maxLineNumberCharLength;
        public scintillaControl()
        {
            InitializeComponent();
            txtEditor.Margins[0].Width = 16;
            DefaultStyle();
        }

        private void txtEditor_TextChanged(object sender, EventArgs e)
        {
            var maxLineNumberCharLength = txtEditor.Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == this.maxLineNumberCharLength)
            {
                return;
            }

            const int padding = 2;
            txtEditor.Margins[0].Width = txtEditor.TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + padding;
            this.maxLineNumberCharLength = maxLineNumberCharLength;
        }

        private void DefaultStyle()
        {
            txtEditor.StyleResetDefault();
            txtEditor.Styles[Style.Default].Font = "Arial";
            txtEditor.Styles[Style.Default].Size = 11;
            txtEditor.StyleClearAll();
        }
    }
}
