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
    public partial class p_catalog : Form
    {
        private font_animation_utils font_animation_utils_bo;
        private font_animation_utils font_animation_utils_bs;
        private font_animation_utils font_animation_utils_bt;
        private font_animation_utils font_animation_utils_bh;
        private font_animation_utils font_animation_utils_bf;

        public p_catalog()
        {
            InitializeComponent();
            InitializeDataGridView();
            PopulateCarList();

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

        private List<HyperCar_data_t> samolet = new List<HyperCar_data_t>();

        public class HyperCar_data_t
        {
            public string Model { get; set; }
            public string BodyType { get; set; }
            public string Color { get; set; }
            public int Year { get; set; }
            public int EngineVolume { get; set; }
            public int Power { get; set; }
        }

        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.RowCount = 7;
            dataGridView1.Columns[0].HeaderText = "Модель";
            dataGridView1.Columns[1].HeaderText = "Тип кузова";
            dataGridView1.Columns[2].HeaderText = "Колір";
            dataGridView1.Columns[3].HeaderText = "Рік випуску";
            dataGridView1.Columns[4].HeaderText = "Об'єм двигуна";
            dataGridView1.Columns[5].HeaderText = "Потужність";

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("Agera RS", "Купе", "Чорний", 2017, 5000, 1160);
            dataGridView1.Rows.Add("Jesko Absolut", "Купе", "Сріблястий", 2022, 5000, 1600);
            dataGridView1.Rows.Add("Gemera", "Купе", "Жовтий", 2024, 2000, 1700);
            dataGridView1.Rows.Add("Regera", "Купе", "Синій", 2020, 5000, 1500);
            dataGridView1.Rows.Add("CCXR Trevita", "Купе", "Білий", 2010, 4800, 1018);
            dataGridView1.Rows.Add("One:1", "Купе", "Червоний", 2014, 5000, 1360);
            dataGridView1.Rows.Add("CCR", "Купе", "Помаранчевий", 2004, 4700, 806);
            dataGridView1.Rows.Add("CC8S", "Купе", "Сріблястий", 2002, 4500, 655);
        }
        private void PopulateCarList()
        {
            samolet.Clear();
            samolet.Add(new HyperCar_data_t { Model = "Agera RS", BodyType = "Купе", Color = "Чорний", Year = 2017, EngineVolume = 5000, Power = 1160 });
            samolet.Add(new HyperCar_data_t { Model = "Jesko Absolut", BodyType = "Купе", Color = "Сріблястий", Year = 2022, EngineVolume = 5000, Power = 1600 });
            samolet.Add(new HyperCar_data_t { Model = "Gemera", BodyType = "Купе", Color = "Жовтий", Year = 2024, EngineVolume = 2000, Power = 1700 });
            samolet.Add(new HyperCar_data_t { Model = "Regera", BodyType = "Купе", Color = "Синій", Year = 2020, EngineVolume = 5000, Power = 1500 });
            samolet.Add(new HyperCar_data_t { Model = "CCXR Trevita", BodyType = "Купе", Color = "Білий", Year = 2010, EngineVolume = 4800, Power = 1018 });
            samolet.Add(new HyperCar_data_t { Model = "One:1", BodyType = "Купе", Color = "Червоний", Year = 2014, EngineVolume = 5000, Power = 1360 });
            samolet.Add(new HyperCar_data_t { Model = "CCR", BodyType = "Купе", Color = "Помаранчевий", Year = 2004, EngineVolume = 4700, Power = 806 });
            samolet.Add(new HyperCar_data_t { Model = "CC8S", BodyType = "Купе", Color = "Сріблястий", Year = 2002, EngineVolume = 4500, Power = 655 });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                using (ColorDialog colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        string newColor = ColorTranslator.ToHtml(colorDialog.Color);

                        dataGridView1.Rows[selectedIndex].Cells[3].Value = newColor;

                        samolet[selectedIndex].Color = newColor;
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть автомобіль для зміни кольору.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                this.Hide();
                application application_page = new application();
                application_page.Left = this.Left;
                application_page.Top = this.Top;
                application_page.Show();
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть автомобіль для купівлі.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
