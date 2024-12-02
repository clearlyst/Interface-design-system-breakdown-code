using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace project
{
    public partial class p_license : Form
    {
        public p_license()
        {
            InitializeComponent();
        }

        private void p_license_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            utils get_close_function = new utils();
            get_close_function.CloseAllForms();
        }

        private int Counter = 0; 
        private const int MaxPages = 9; 
        private List<Label> Text_Pages = new List<Label>(); 

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Text_Pages.Count > 0)
            {
                Label lastPage = Text_Pages[Text_Pages.Count - 1];
                this.Controls.Remove(lastPage);
                Text_Pages.Remove(lastPage);

                Counter--;
                this.label2.Text = $"Сторінок: {Counter}";
            }
            else
            {
                MessageBox.Show("Сторінок немає для видалення!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Counter < MaxPages)
            {
                Counter++;

                Label new_text = new Label
                {

                };

                this.Controls.Add(new_text);
                Text_Pages.Add(new_text);

                this.label2.Text = $"Сторінок: {Counter}";
            }
            else
            {
                MessageBox.Show("Досягнуто максимальну кількість сторінок!", "Попереджен");
            }
        } 

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

            p_void void_page = new p_void();
            void_page.Left = this.Left;
            void_page.Top = this.Top;
            void_page.Show();
        }
    }
}
