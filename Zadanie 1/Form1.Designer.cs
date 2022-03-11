namespace Zadanie_1
{
    partial class Kalkulator
    {
        /// <summary>
        double wynik = 0;
        String dzialanie = "";
        bool czyDzialanie = false;
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wybierzPlikDoSkórkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cyfra_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kalkulator_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cyfra_Click);
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kalkulator_KeyPress);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.cyfra_Click);
            this.button3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kalkulator_KeyPress);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(28, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "0";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.cyfra_Click);
            this.button4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kalkulator_KeyPress);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 158);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 41);
            this.button5.TabIndex = 4;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.cyfra_Click);
            this.button5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kalkulator_KeyPress);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(79, 158);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 41);
            this.button6.TabIndex = 5;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.cyfra_Click);
            this.button6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kalkulator_KeyPress);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(130, 158);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 41);
            this.button7.TabIndex = 6;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.cyfra_Click);
            this.button7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kalkulator_KeyPress);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(28, 111);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 41);
            this.button8.TabIndex = 7;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.cyfra_Click);
            this.button8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kalkulator_KeyPress);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(79, 111);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 41);
            this.button9.TabIndex = 8;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.cyfra_Click);
            this.button9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kalkulator_KeyPress);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(130, 111);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(45, 41);
            this.button10.TabIndex = 9;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.cyfra_Click);
            this.button10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kalkulator_KeyPress);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(234, 111);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(45, 41);
            this.button11.TabIndex = 10;
            this.button11.Text = "CE";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.CE_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(232, 158);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(47, 41);
            this.button12.TabIndex = 11;
            this.button12.Text = "C";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.C_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(234, 205);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(45, 88);
            this.button13.TabIndex = 14;
            this.button13.Text = "=";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.wynik_Click);
            this.button13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kalkulator_KeyPress);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(181, 252);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(47, 41);
            this.button14.TabIndex = 15;
            this.button14.Text = "+";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.operatory_Click);
            this.button14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kalkulator_KeyPress);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(181, 205);
            this.button15.Name = "button15";
            this.button15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button15.Size = new System.Drawing.Size(47, 41);
            this.button15.TabIndex = 16;
            this.button15.Text = "-";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.operatory_Click);
            this.button15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kalkulator_KeyPress);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(181, 158);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(47, 41);
            this.button16.TabIndex = 17;
            this.button16.Text = "*";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.operatory_Click);
            this.button16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kalkulator_KeyPress);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(130, 252);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(45, 41);
            this.button17.TabIndex = 18;
            this.button17.Text = ",";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.przecinek_Click);
            this.button17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kalkulator_KeyPress);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(181, 111);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(47, 41);
            this.button18.TabIndex = 19;
            this.button18.Text = "/";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.operatory_Click);
            this.button18.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kalkulator_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(28, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 45);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wybierzPlikDoSkórkiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(307, 28);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wybierzPlikDoSkórkiToolStripMenuItem
            // 
            this.wybierzPlikDoSkórkiToolStripMenuItem.Name = "wybierzPlikDoSkórkiToolStripMenuItem";
            this.wybierzPlikDoSkórkiToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.wybierzPlikDoSkórkiToolStripMenuItem.Text = "Wybierz plik do tła";
            this.wybierzPlikDoSkórkiToolStripMenuItem.Click += new System.EventHandler(this.wybierzPlikDoTłaToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 26;
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 323);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Kalkulator";
            this.Text = "Kalkulator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kalkulator_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem wybierzPlikDoSkórkiToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private Label label2;
    }
}