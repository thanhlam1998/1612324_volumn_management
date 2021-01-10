using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1612324_compress_volume
{
    public partial class ViewDialog: System.Windows.Forms.Form
    {
        public ViewDialog()
        {
            InitializeComponent();
        }

        private void ViewDialog_Load(object sender, EventArgs e)
        {

        }

        public void SetContent (string text)
        {
            richTextBox.Text = text;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ViewDialog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                Hide();
            }
        }
    }
}
