using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LabMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void обАвтореToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.Text += "Смертин Д.А., 2 курс, Институт киберфизических систем, группа 3135." + Environment.NewLine;
        }

        private void лаб1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void журналЛоговToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StreamReader sr = new StreamReader("F:\\Logger\\log.txt", Encoding.UTF8);
            string text = sr.ReadToEnd();
            richTextBox1.AppendText(text);
        }

        private void допЗаданиеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void лаб21ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form3 f3 = new Form3();
            f3.ShowDialog();

        }
    }
}