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

        private void ��������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.Text += "������� �.�., 2 ����, �������� ��������������� ������, ������ 3135." + Environment.NewLine;
        }

        private void ���1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StreamReader sr = new StreamReader("F:\\Logger\\log.txt", Encoding.UTF8);
            string text = sr.ReadToEnd();
            richTextBox1.AppendText(text);
        }

        private void ����������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void ���21ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form3 f3 = new Form3();
            f3.ShowDialog();

        }
    }
}