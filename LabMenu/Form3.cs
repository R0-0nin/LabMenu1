using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vigenère_Cipher_Form;

namespace LabMenu
{
    public partial class Form3 : Form
    {
        public int firstnum;
        public int plusnum;
        int[] mas;
        int n;
        Random ran = new Random();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            freqtb.ReadOnly = true; // Далее происходит создание DataGridView 
            num.Value = 6;

            this.dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.RowCount = 2;
            this.dataGridView1.Rows[0].MinimumHeight = 50;
            this.dataGridView1.Rows[1].MinimumHeight = 50;

            this.dataGridView1.Rows[1].ReadOnly = true;



            this.dataGridView1.ColumnHeadersHeight = 100;
            this.dataGridView1.Rows[0].HeaderCell.Value = "Исходный\nМассив";
            this.dataGridView1.Rows[1].HeaderCell.Value = "Конечный\nМассив";
            this.dataGridView1.ColumnCount = 6;
            for (int i = 0; i < 6; i++)
            {
                this.dataGridView1.Columns[i].HeaderCell.Value = (i + 1).ToString();

            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
        }

        private void num_ValueChanged(object sender, EventArgs e)
        {
            //Функция, описывающая действия, происходящие при смене числа в numericUpDown
            this.dataGridView1.ColumnCount = (int)num.Value;

            for (int i = 0; i < num.Value; i++)
            {
                this.dataGridView1.Columns[i].HeaderCell.Value = (i + 1).ToString();
                this.dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void num_KeyPress(object sender, KeyPressEventArgs e) // Функция, запрещающая ввод букв и прочих символов, кроме чисел в numericUpDown
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rbyourself_CheckedChanged(object sender, EventArgs e) // Функция, которая взаимодействует с интерфейсом, при нажатии на radiobutton "Вручную"
        {
            errorProvider1.Dispose();
            this.dataGridView1.Rows[0].ReadOnly = false;
            Timer.Enabled = false;
            freqtb.Text = "";
            
        }

        private void createbt_Click(object sender, EventArgs e) // Функция, описывающая все виды взаимодействия при нажатии на кнопку "Сформировать"
        {
            if (rbrand.Checked == true) // При нажатии на "Случайно"
            {
                plusnum = 0;
                n = (int)this.num.Value;
                mas = new int[n];
                for (int j = 0; j < num.Value; j++)
                {



                }
                for (int i = 0; i < num.Value; i++)
                {

                    mas[i] = ran.Next(-100, 100);
                    this.dataGridView1.Rows[0].Cells[i].Value = mas[i];

                    if (mas[0] == 0)
                    {

                        while (mas[0] == 0)
                        {

                            mas[0] = ran.Next(-100, 100);

                        }

                    }

                    this.dataGridView1.Rows[0].Cells[i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    this.dataGridView1.Rows[1].Cells[i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    if (i == 0 || i % 2 == 0)
                    {

                        this.dataGridView1.Rows[1].Cells[i].Value = mas[i] * 2;

                    }

                    else
                    {

                        this.dataGridView1.Rows[1].Cells[i].Value = mas[i] * mas[i];

                    }
                }
                for (int i = 0; i < num.Value; i++)
                {

                    if (i % 2 != 0)
                    {

                        this.dataGridView1.Rows[1].Cells[i].Value = Convert.ToInt32(this.dataGridView1.Rows[1].Cells[i].Value) / Convert.ToInt32(this.dataGridView1.Rows[1].Cells[0].Value);
                        if (Convert.ToInt32(this.dataGridView1.Rows[1].Cells[i].Value) > 0)
                        {

                            plusnum = i;

                        }

                    }
                    else if (i % 2 == 0)
                    {

                        if (Convert.ToInt32(this.dataGridView1.Rows[1].Cells[i].Value) > 0)
                        {

                            plusnum = i;

                        }

                    }

                }

                this.dataGridView1.Rows[1].Cells[plusnum].Value = this.dataGridView1.Rows[1].Cells[1].Value;


            }



            else if (rbyourself.Checked == true) // При нажатии на "Вручную"
            {
                plusnum = 0;
                n = (int)this.num.Value;
                mas = new int[n];
                int firstflag = 0;

                for (int i = 0; i < num.Value; i++)
                {
                    for (int j = 0; j < num.Value; j++)
                    {

                        if (this.dataGridView1.Rows[0].Cells[j].Value == null || this.dataGridView1.Rows[0].Cells[j].Value == "")
                        {
                            logger.WriteLog("Введите значения в клетки!");
                            errorProvider2.SetError(createbt, "Введите значения в клетки!");
                            return;
                        }
                        else if (Convert.ToInt32(this.dataGridView1.Rows[0].Cells[i].Value) == 0)
                        {
                            logger.WriteLog("Первым числом не может быть 0!");
                            errorProvider2.SetError(createbt, "Первым числом не может быть 0!");
                            return;

                        }

                    }



                    if (firstflag != 1)
                    {

                        firstnum = Convert.ToInt32(this.dataGridView1.Rows[0].Cells[i].Value) * 2;
                        firstflag = 1;

                    }

                    if (i == 0 || i % 2 == 0)
                    {


                        this.dataGridView1.Rows[1].Cells[i].Value = Convert.ToInt32(this.dataGridView1.Rows[0].Cells[i].Value) * 2;

                    }

                    else if (i % 2 != 0)
                    {

                        this.dataGridView1.Rows[1].Cells[i].Value = (Convert.ToInt32(this.dataGridView1.Rows[0].Cells[i].Value) * Convert.ToInt32(this.dataGridView1.Rows[0].Cells[i].Value)) / firstnum;

                    }

                    if (Convert.ToInt32(this.dataGridView1.Rows[1].Cells[i].Value) > 0)
                    {

                        plusnum = i;


                    }

                    

                }

                this.dataGridView1.Rows[1].Cells[plusnum].Value = this.dataGridView1.Rows[1].Cells[1].Value;
                errorProvider2.Dispose();

            }
            else if (randfreqrb.Checked == true) // При нажатии на "Случайно с частотой"
            {
                
                if (freqtb.Text != "")
                {

                    if (freqtb.Text[0] == '0')
                    {

                        freqtb.Text = "1";
                        Timer.Interval = 1;

                    }
                    else
                    {
                        Timer.Interval = Convert.ToInt32(freqtb.Text);
                    }

                }

                else
                {
                    logger.WriteLog("Введите частоту!");
                    errorProvider1.SetError(freqtb, "Введите частоту!");
                    return;
                }
                errorProvider1.Dispose();
                Timer.Enabled = true;
            }


        }

        private void timer1_Tick(object sender, EventArgs e) // Функция работы таймера(запуск функции "Случайно" с введенной периодичностью)
        {
            plusnum = 0;
            n = (int)this.num.Value;
            mas = new int[n];
            for (int j = 0; j < num.Value; j++)
            {



            }
            for (int i = 0; i < num.Value; i++)
            {

                mas[i] = ran.Next(-100, 100);
                this.dataGridView1.Rows[0].Cells[i].Value = mas[i];

                if (mas[0] == 0)
                {

                    while (mas[0] == 0)
                    {

                        mas[0] = ran.Next(-100, 100);

                    }

                }

                this.dataGridView1.Rows[0].Cells[i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Rows[1].Cells[i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                if (i == 0 || i % 2 == 0)
                {

                    this.dataGridView1.Rows[1].Cells[i].Value = mas[i] * 2;

                }

                else
                {

                    this.dataGridView1.Rows[1].Cells[i].Value = mas[i] * mas[i];

                }
            }
            for (int i = 0; i < num.Value; i++)
            {

                if (i % 2 != 0)
                {

                    this.dataGridView1.Rows[1].Cells[i].Value = Convert.ToInt32(this.dataGridView1.Rows[1].Cells[i].Value) / Convert.ToInt32(this.dataGridView1.Rows[1].Cells[0].Value);
                    if (Convert.ToInt32(this.dataGridView1.Rows[1].Cells[i].Value) > 0)
                    {

                        plusnum = i;

                    }

                }
                else if (i % 2 == 0)
                {

                    if (Convert.ToInt32(this.dataGridView1.Rows[1].Cells[i].Value) > 0)
                    {

                        plusnum = i;

                    }

                }

            }

            this.dataGridView1.Rows[1].Cells[plusnum].Value = this.dataGridView1.Rows[1].Cells[1].Value;

        }
        void Control_NumberPress(object sender, KeyPressEventArgs e) 
        {
            if (e.KeyChar != 8)
                e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void rbrand_CheckedChanged(object sender, EventArgs e) // Функция, которая взаимодействует с интерфейсом, при нажатии на radiobutton "Случайно"
        {
            errorProvider2.Dispose();
            this.dataGridView1.Rows[0].ReadOnly = true;
            errorProvider1.Dispose();
            
            Timer.Enabled = false;
            freqtb.Text = "";
        }

        private void clearbt_Click(object sender, EventArgs e) // Функция взаимодействия при нажатии на кнопку "Очистить"
        {
            Timer.Enabled = false;
            freqtb.Text = "";
            
            for (int i = 0; i < (int)num.Value; i++)
            {

                this.dataGridView1.Rows[0].Cells[i].Value = null;

            }
            for (int i = 0; i < (int)num.Value; i++)
            {

                this.dataGridView1.Rows[1].Cells[i].Value = null;

            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) // Контроль ввода в ячейки DataGridView
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbyourself_Click(object sender, EventArgs e) // Функция, которая взаимодействует с интерфейсом, при нажатии на radiobutton "Вручную"
        {
            freqtb.ReadOnly = true;
            for (int i = 0; i < (int)num.Value; i++)
            {

                this.dataGridView1.Rows[0].Cells[i].Value = null;

            }
            for (int i = 0; i < (int)num.Value; i++)
            {

                this.dataGridView1.Rows[1].Cells[i].Value = null;

            }
        }

        private void rbrand_Click(object sender, EventArgs e) // Функция, которая взаимодействует с интерфейсом, при нажатии на radiobutton "Случайно"
        {
            freqtb.ReadOnly = true;
            for (int i = 0; i < (int)num.Value; i++)
            {

                this.dataGridView1.Rows[0].Cells[i].Value = null;

            }
            for (int i = 0; i < (int)num.Value; i++)
            {

                this.dataGridView1.Rows[1].Cells[i].Value = null;

            }
        }

        private void randfreqrb_CheckedChanged(object sender, EventArgs e) // Функция, которая взаимодействует с интерфейсом, при нажатии на radiobutton "Случайно с заданной частотой"
        {
            errorProvider2.Dispose();
            freqtb.ReadOnly = false;
            
        }

        private void freqtb_KeyPress(object sender, KeyPressEventArgs e) // Контроль ввода в Textbox для частоты
        {
            if (((!Char.IsNumber(e.KeyChar) && (e.KeyChar != (char)8))))
            {
                if ((e.KeyChar != (char)Keys.Back) || (e.KeyChar != (char)Keys.Delete))
                {
                    e.Handled = true;
                }
            }
        }

        private void randfreqrb_Click(object sender, EventArgs e) // Функция, которая взаимодействует с интерфейсом, при нажатии на radiobutton "Случайно с заданной частотой"
        {
            for (int i = 0; i < (int)num.Value; i++)
            {

                this.dataGridView1.Rows[0].Cells[i].Value = null;

            }
            for (int i = 0; i < (int)num.Value; i++)
            {

                this.dataGridView1.Rows[1].Cells[i].Value = null;

            }
        }
        void tb_KeyPress(object sender, KeyPressEventArgs e) // Контроль ввода в Textbox для содержимого ячеек
        {
            if (!Char.IsNumber(e.KeyChar) && (e.KeyChar != (char)8) && (e.KeyChar != (char)45))
            {
                if ((e.KeyChar != (char)Keys.Back) || (e.KeyChar != (char)Keys.Delete))
                {
                    e.Handled = true;
                }
            }

        }
    }
}
