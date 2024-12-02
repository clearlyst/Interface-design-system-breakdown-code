using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class p_status : Form
    {
        public p_status()
        {
            InitializeComponent();
            SanityAtNetWork();
            TextChangesOnStatus();
            switch_page();
        }

        private void offline_connection_Load(object sender, EventArgs e)
        {

        }

        bool status = false;

        HttpWebRequest request = WebRequest.Create("https://google.com/") as HttpWebRequest;
        HttpWebResponse response;

        public void SanityAtNetWork()
        {
            try
            {
                response = request.GetResponse() as HttpWebResponse;
            }
            catch (WebException e)
            {
                if (e.Response is HttpWebResponse)
                {
                    response = e.Response as HttpWebResponse;
                }
                else
                {
                    response = null;
                }
            }

            if (response != null)
            {
                Console.WriteLine(response.StatusCode);
            }
        }

        public void TextChangesOnStatus()
        {
            if (response == null)
            {
                this.label1.ForeColor = Color.FromArgb(255, 242, 0, 0);
                this.label1.Text = "Статус: Оффлайн";
                this.label2.Text = "Немає доступу до інтернету";
                this.pictureBox1.Location = new Point(460, 12);
                this.pictureBox1.Image = Properties.Resources.offline_status;

                status = false;
            }
            else
            {
                status = true;

                this.label1.ForeColor = Color.FromArgb(255, 0, 153, 102);
                this.label1.Text = "Статус: Онлайн";
                this.label2.Text = "Завантаження";
                this.pictureBox1.Location = new Point(485, 12);
                this.pictureBox1.Image = Properties.Resources.online_status;
            }
        }

        private async void switch_page()
        {
            if (status)
            {
                await Task.Delay(5000);
                this.Hide();

                p_main main_page = new p_main();
                main_page.Left = this.Left;
                main_page.Top = this.Top;
                main_page.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            utils get_close_function = new utils();
            get_close_function.CloseAllForms();
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

            label2.ForeColor = Color.FromArgb(colorValue, colorValue, colorValue);
        }
    }
}
