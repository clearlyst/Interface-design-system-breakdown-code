using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project
{
    public partial class p_void : Form
    {
        public p_void()
        {
            InitializeComponent();
            this.checkBox1.Checked = false;
            this.button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            p_network network_page = new p_network();
            network_page.Left = this.Left;
            network_page.Top = this.Top;
            network_page.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            utils get_close_function = new utils();
            get_close_function.CloseAllForms();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                this.button1.Enabled = true;
            }
            else
            {
                this.button1.Enabled = false;
            }
        }

        private bool wasAlreadyClickedOnce;

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (!wasAlreadyClickedOnce)
            {
                wasAlreadyClickedOnce = true;
                return;
            }

            this.Hide();
            p_license license_page = new p_license();
            license_page.Left = this.Left;
            license_page.Top = this.Top;
            license_page.Show();
        }
    }
}
