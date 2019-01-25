using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cpnp_selenium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_to_cpnp_click(object sender, EventArgs e)
        {
            Program.Login2cpnp();
        }

        private void on_close(object sender, FormClosingEventArgs e)
        {
            if (Program.brw != null)
            {
                Program.brw.Quit();
                Program.brw = null;
            }
        }
    }
}
