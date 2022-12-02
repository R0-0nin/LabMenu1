namespace LabMenu
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rbyourself = new System.Windows.Forms.RadioButton();
            this.rbrand = new System.Windows.Forms.RadioButton();
            this.randfreqrb = new System.Windows.Forms.RadioButton();
            this.freqlbl = new System.Windows.Forms.Label();
            this.freqtb = new System.Windows.Forms.TextBox();
            this.createbt = new System.Windows.Forms.Button();
            this.clearbt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите длину массива:";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(30, 49);
            this.num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(36, 23);
            this.num.TabIndex = 1;
            this.num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            this.num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Способ ввода массива";
            // 
            // rbyourself
            // 
            this.rbyourself.AutoSize = true;
            this.rbyourself.Location = new System.Drawing.Point(601, 49);
            this.rbyourself.Name = "rbyourself";
            this.rbyourself.Size = new System.Drawing.Size(75, 19);
            this.rbyourself.TabIndex = 3;
            this.rbyourself.TabStop = true;
            this.rbyourself.Text = "Вручную";
            this.rbyourself.UseVisualStyleBackColor = true;
            this.rbyourself.CheckedChanged += new System.EventHandler(this.rbyourself_CheckedChanged);
            this.rbyourself.Click += new System.EventHandler(this.rbyourself_Click);
            // 
            // rbrand
            // 
            this.rbrand.AutoSize = true;
            this.rbrand.Location = new System.Drawing.Point(601, 74);
            this.rbrand.Name = "rbrand";
            this.rbrand.Size = new System.Drawing.Size(80, 19);
            this.rbrand.TabIndex = 4;
            this.rbrand.TabStop = true;
            this.rbrand.Text = "Случайно";
            this.rbrand.UseVisualStyleBackColor = true;
            this.rbrand.CheckedChanged += new System.EventHandler(this.rbrand_CheckedChanged);
            this.rbrand.Click += new System.EventHandler(this.rbrand_Click);
            // 
            // randfreqrb
            // 
            this.randfreqrb.AutoSize = true;
            this.randfreqrb.Location = new System.Drawing.Point(601, 99);
            this.randfreqrb.Name = "randfreqrb";
            this.randfreqrb.Size = new System.Drawing.Size(142, 19);
            this.randfreqrb.TabIndex = 5;
            this.randfreqrb.TabStop = true;
            this.randfreqrb.Text = "Случайно с частотой";
            this.randfreqrb.UseVisualStyleBackColor = true;
            this.randfreqrb.CheckedChanged += new System.EventHandler(this.randfreqrb_CheckedChanged);
            this.randfreqrb.Click += new System.EventHandler(this.randfreqrb_Click);
            // 
            // freqlbl
            // 
            this.freqlbl.AutoSize = true;
            this.freqlbl.Location = new System.Drawing.Point(601, 134);
            this.freqlbl.Name = "freqlbl";
            this.freqlbl.Size = new System.Drawing.Size(76, 15);
            this.freqlbl.TabIndex = 6;
            this.freqlbl.Text = "Частота(мс):";
            // 
            // freqtb
            // 
            this.freqtb.Location = new System.Drawing.Point(683, 130);
            this.freqtb.Name = "freqtb";
            this.freqtb.Size = new System.Drawing.Size(60, 23);
            this.freqtb.TabIndex = 7;
            this.freqtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.freqtb_KeyPress);
            // 
            // createbt
            // 
            this.createbt.Location = new System.Drawing.Point(30, 130);
            this.createbt.Name = "createbt";
            this.createbt.Size = new System.Drawing.Size(112, 23);
            this.createbt.TabIndex = 8;
            this.createbt.Text = "Сформировать";
            this.createbt.UseVisualStyleBackColor = true;
            this.createbt.Click += new System.EventHandler(this.createbt_Click);
            // 
            // clearbt
            // 
            this.clearbt.Location = new System.Drawing.Point(165, 130);
            this.clearbt.Name = "clearbt";
            this.clearbt.Size = new System.Drawing.Size(112, 23);
            this.clearbt.TabIndex = 9;
            this.clearbt.Text = "Очистить";
            this.clearbt.UseVisualStyleBackColor = true;
            this.clearbt.Click += new System.EventHandler(this.clearbt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(798, 281);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clearbt);
            this.Controls.Add(this.createbt);
            this.Controls.Add(this.freqtb);
            this.Controls.Add(this.freqlbl);
            this.Controls.Add(this.randfreqrb);
            this.Controls.Add(this.rbrand);
            this.Controls.Add(this.rbyourself);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Формирование массивов.3135_Смертин";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private ErrorProvider errorProvider1;
        private DataGridView dataGridView1;
        private Button clearbt;
        private Button createbt;
        private TextBox freqtb;
        private Label freqlbl;
        private RadioButton randfreqrb;
        private RadioButton rbrand;
        private RadioButton rbyourself;
        private Label label2;
        private NumericUpDown num;
        private Label label1;
        private ErrorProvider errorProvider2;
    }
}