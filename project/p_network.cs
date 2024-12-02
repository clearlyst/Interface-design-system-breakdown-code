using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class p_network : Form
    {
        public p_network()
        {
            InitializeComponent();
        }

        private async void p_network_Load(object sender, EventArgs e)
        {
            await Task.Delay(5000);

            this.Hide();
            p_status p_connection = new p_status();
            p_connection.Left = this.Left;
            p_connection.Top = this.Top;
            p_connection.Show();
        }

        private int colorValue = 255; 
        private int step = -1;        

        private void timer1_Tick(object sender, EventArgs e)
        {
            colorValue += step;

            if (colorValue <= 15 || colorValue >= 255)
            {
                step *= -1; 
            }

            label1.ForeColor = Color.FromArgb(colorValue, colorValue, colorValue);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            utils get_close_function = new utils();
            get_close_function.CloseAllForms();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
