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
    public partial class application : Form
    {
        public application()
        {
            InitializeComponent();

            monthCalendar1.MinDate = DateTime.Today.AddMonths(6);

            monthCalendar1.DateChanged += (sender, e) =>
            {
                DateTime selectedDate = e.Start;

                if (selectedDate < DateTime.Today.AddMonths(6))
                {
                    MessageBox.Show("Гіперкар будуєтся на заводі мінімум 6 місяців", "Помилка дати", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    monthCalendar1.SetDate(DateTime.Today.AddMonths(6));
                }
                else
                {
                    MessageBox.Show($"Ви вибрали дату доставки: {selectedDate.ToShortDateString()}", "Повідомлення",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            button7.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Заповніть будь-ласка перше поле", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Заповніть будь-ласка друге поле", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Заповніть будь-ласка третє поле", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { 
                MessageBox.Show("Дякуюємо за вибір нашого сервісу. Очікуйте нашої відповіді.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

                utils get_close_function = new utils();
                get_close_function.CloseAllForms();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Check()
        {
            if (checkBox1.Checked == true)
            {
                if (checkBox2.Checked == true)
                {
                    button7.Enabled = true;
                }
                else
                {
                    button7.Enabled = false;
                }
            }
            else
            {
                button7.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
 
        }
    }
}
