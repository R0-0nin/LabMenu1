namespace LabMenu
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wordtb = new System.Windows.Forms.TextBox();
            this.keytb = new System.Windows.Forms.TextBox();
            this.restb = new System.Windows.Forms.TextBox();
            this.calcbt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Word(Cypher)";
            // 
            // wordtb
            // 
            this.wordtb.Location = new System.Drawing.Point(34, 45);
            this.wordtb.Name = "wordtb";
            this.wordtb.Size = new System.Drawing.Size(100, 23);
            this.wordtb.TabIndex = 2;
            this.wordtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wordtb_KeyPress_1);
            // 
            // keytb
            // 
            this.keytb.Location = new System.Drawing.Point(34, 112);
            this.keytb.Name = "keytb";
            this.keytb.Size = new System.Drawing.Size(100, 23);
            this.keytb.TabIndex = 3;
            this.keytb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keytb_KeyPress_1);
            // 
            // restb
            // 
            this.restb.Location = new System.Drawing.Point(222, 45);
            this.restb.Name = "restb";
            this.restb.ReadOnly = true;
            this.restb.Size = new System.Drawing.Size(100, 23);
            this.restb.TabIndex = 4;
            this.restb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // calcbt
            // 
            this.calcbt.Location = new System.Drawing.Point(222, 111);
            this.calcbt.Name = "calcbt";
            this.calcbt.Size = new System.Drawing.Size(100, 23);
            this.calcbt.TabIndex = 5;
            this.calcbt.Text = "Cypher";
            this.calcbt.UseVisualStyleBackColor = true;
            this.calcbt.Click += new System.EventHandler(this.calcbt_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Key";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 171);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calcbt);
            this.Controls.Add(this.restb);
            this.Controls.Add(this.keytb);
            this.Controls.Add(this.wordtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Лаб2_Доп.3135_Смертин";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox wordtb;
        private TextBox keytb;
        private TextBox restb;
        private Button calcbt;
        private Label label3;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}