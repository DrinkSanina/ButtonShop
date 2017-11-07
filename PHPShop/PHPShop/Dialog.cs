using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHPShop
{
    public partial class Dialog : Form
    {
        String message;
        public Dialog(String res)
        {
            InitializeComponent();
            message = res;
        }

        private void OkB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dialog_Load(object sender, EventArgs e)
        {
            label1.Text = message;
        }
    }
}
