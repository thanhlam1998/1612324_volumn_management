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
    public partial class UserInputDialog : System.Windows.Forms.Form
    {

        // show dialog and return value to the user
        public string GetString(string caption)
        {
            return GetString(caption, "");
        }

        public string GetString(string caption, string defValue)
        {
            // initializae dialog
            Text = caption;
            txtUser.Text = defValue;
            txtUser.SelectAll();

            // show dialog
            DialogResult dr = ShowDialog();

            // return null if the user cancel
            if (dr != DialogResult.OK)
            {
                return null;
            }
            // otherwise, return value to the user
            return txtUser.Text;
        }

        // handle OK and cancel button
        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
        }

        public UserInputDialog()
        {
            InitializeComponent();
        }

        private void UserInputDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
