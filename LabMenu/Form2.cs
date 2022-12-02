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
    public partial class Form2 : Form
    {
        public string alpha = "abcdefghijklmnopqrstuvwxyz"; // Задаем алфавит
        public Form2()
        {
            InitializeComponent();
        }
       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void wordtb_KeyPress_1(object sender, KeyPressEventArgs e) // Контроль ввода в Textbox для слова
        {
            char l = e.KeyChar;
            if ((l < 'a' || l > 'z') && (l < 'A' || l > 'Z') && l != '\b')
            {
                e.Handled = true;
            }
        }

        private void keytb_KeyPress_1(object sender, KeyPressEventArgs e) // Контроль ввода в Textbox для ключа
        {

            char l = e.KeyChar;
            if ((l < 'a' || l > 'z') && (l < 'A' || l > 'Z') && l != '\b')
            {
                e.Handled = true;
            }
        }

        private void calcbt_Click_1(object sender, EventArgs e) // При нажатии кнопки "Cypher"
        {
            if (wordtb.Text == "" && keytb.Text == "") // Ниже ведение лог-журнала, вывод ошибки в интерфейс при отсутствии символов в TextBox
            {
                logger.WriteLog("Не введены слово и ключ");
                errorProvider1.SetError(wordtb, "Enter your word!");
                errorProvider2.SetError(keytb, "Enter your key!");
                return;
            }

            else if (wordtb.Text == "")
            {
                logger.WriteLog("Не введено слово");
                errorProvider2.Dispose();
                errorProvider1.SetError(wordtb, "Enter your word!");
                return;

            }

            else if (keytb.Text == "")
            {
                logger.WriteLog("Не введен ключ");
                errorProvider1.Dispose();
                errorProvider2.SetError(keytb, "Enter your key!");
                return;

            }

            else
            {
                errorProvider1.Dispose();
                errorProvider2.Dispose();

            }



            string name = wordtb.Text.ToLower();
            string keyword = keytb.Text.ToLower();
            var table = new char[alpha.Length, alpha.Length]; // Создаю таблицу Виженера для английского
            string finalname = "";
            string finalestname = "";


            for (int i = 0; i < alpha.Length; i++) // Создаю таблицу Виженера для английского
            {
                for (int j = 0; j < alpha.Length; j++)
                {

                    int num = (i + j) % alpha.Length;
                    table[i, j] = alpha[num];

                }
            }

            int y = 0;
            int x = 0;

            int somevar = 0;

            for (int i = 0; i < name.Length; i++) // Начало шифрования
            {

                for (int row = 0; row < alpha.Length; row++) // Прохожу по ряду для слова
                {

                    if (table[row, 0] == name[i])
                    {

                        y = row;
                        break;
                    }

                }

                for (int col = 0; col < alpha.Length; col++) // Прохожу по колонны для ключа
                {
                    if (somevar > keyword.Length - 1)
                    {

                        somevar = 0;

                    }

                    if (table[0, col] == keyword[somevar])
                    {

                        x = col;
                        break;

                    }


                }
                somevar++;
                finalname += table[x, y]; // Собираю слово

            }




            for (int i = 0; i < finalname.Length; i++) // Функция для корректного вывода регистра каждого символа введённого слова
            {

                if (wordtb.Text[i] == char.ToUpper(wordtb.Text[i]))
                {

                    finalestname += char.ToUpper(finalname[i]);

                }
                else
                {

                    finalestname += char.ToLower(finalname[i]);

                }

            }

            restb.Text = finalestname; // Вывожу слово в TextBox
        }
    }
}
