using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class p_main : Form
    {
        private font_animation_utils font_animation_utils_bo;
        private font_animation_utils font_animation_utils_bs;
        private font_animation_utils font_animation_utils_bt;
        private font_animation_utils font_animation_utils_bh;
        private font_animation_utils font_animation_utils_bf;

        public p_main()
        {
            InitializeComponent();

            font_animation_utils_bo = new font_animation_utils(button1, 22f);
            font_animation_utils_bs = new font_animation_utils(button2, 22f);
            font_animation_utils_bt = new font_animation_utils(button3, 22f);
            font_animation_utils_bh = new font_animation_utils(button4, 22f);
            font_animation_utils_bf = new font_animation_utils(button5, 22f);

            button1.MouseEnter += (s, e) => font_animation_utils_bo.StartExpand();
            button1.MouseLeave += (s, e) => font_animation_utils_bo.StartCollapse();
            button2.MouseEnter += (s, e) => font_animation_utils_bs.StartExpand();
            button2.MouseLeave += (s, e) => font_animation_utils_bs.StartCollapse();
            button3.MouseEnter += (s, e) => font_animation_utils_bt.StartExpand();
            button3.MouseLeave += (s, e) => font_animation_utils_bt.StartCollapse();
            button4.MouseLeave += (s, e) => font_animation_utils_bh.StartCollapse();
            button4.MouseEnter += (s, e) => font_animation_utils_bh.StartExpand();
            button5.MouseLeave += (s, e) => font_animation_utils_bf.StartCollapse();
            button5.MouseEnter += (s, e) => font_animation_utils_bf.StartExpand();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            utils get_close_function = new utils();
            get_close_function.CloseAllForms();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            p_main main_page = new p_main();
            main_page.Left = this.Left;
            main_page.Top = this.Top;
            main_page.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p_history history_page = new p_history();
            history_page.Left = this.Left;
            history_page.Top = this.Top;
            history_page.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p_catalog catalog_page = new p_catalog();
            catalog_page.Left = this.Left;
            catalog_page.Top = this.Top;
            catalog_page.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p_technology technology_page = new p_technology();
            technology_page.Left = this.Left;
            technology_page.Top = this.Top;
            technology_page.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p_contact contact_page = new p_contact();
            contact_page.Left = this.Left;
            contact_page.Top = this.Top;
            contact_page.Show();
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

            button1.ForeColor = Color.FromArgb(colorValue, colorValue, colorValue);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
