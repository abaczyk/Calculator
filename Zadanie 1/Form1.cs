namespace Zadanie_1
{
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
        }
        private void cyfra_Click(object sender, EventArgs e)
        {
            Button cyfra = (Button)sender;
            if (textBox1.Text.Equals("0") || czyDzialanie) 
                textBox1.Text = cyfra.Text;
            else textBox1.Text += cyfra.Text;     
            czyDzialanie = false;
        }

        private void przecinek_Click(object sender, EventArgs e)
        {
          
            if (!textBox1.Text.Contains(","))
            {
                if (textBox1.Text.Equals("") )
                    textBox1.Text = "0,";
                else textBox1.Text += ",";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
        private void operatory_Click(object sender, EventArgs e)
        {
            Button operatory = (Button)sender;
            if (wynik != 0)
            {
                button12.PerformClick();
                dzialanie = operatory.Text;
                label2.Text = wynik + " " + dzialanie;
                czyDzialanie = true;
            }
            else
            {
                dzialanie = operatory.Text;
                wynik = double.Parse(textBox1.Text);
                label2.Text = wynik + " " + dzialanie;
                czyDzialanie = true;
            }
        }

        private void wynik_Click(object sender, EventArgs e)
        {
            switch (dzialanie)
            {
                case "+":
                    textBox1.Text = (wynik + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (wynik - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (wynik * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    if (double.IsInfinity(wynik / double.Parse(textBox1.Text))) 
                    {
                        MessageBox.Show("Nie mo¿na dzieliæ przez 0");
                        break;
                    }
                    else 
                        textBox1.Text = (wynik / double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            wynik = double.Parse(textBox1.Text);
            label2.Text = "";
        }
        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            wynik = 0;
            label2.Text = "";
        }
        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        private void wybierzPlikDoT³aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.ShowDialog();
            try
            {
                this.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            catch (System.IO.FileNotFoundException ex1)
            {
                MessageBox.Show(ex1.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("B³êdne rozszerzenie pliku");
            }
        }
        private void Kalkulator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                this.button17.PerformClick();
            }
            if (e.KeyChar == '0')
            {
                this.button4.PerformClick();
            }
            if (e.KeyChar == '1')
            {
                this.button1.PerformClick();
            }
            if (e.KeyChar == '2')
            {
                this.button2.PerformClick();
            }
            if (e.KeyChar == '3')
            {
                this.button3.PerformClick();
            }
            if (e.KeyChar == '4')
            {
                this.button5.PerformClick();
            }
            if (e.KeyChar == '5')
            {
                this.button6.PerformClick();
            }
            if (e.KeyChar == '6')
            {
                this.button7.PerformClick();
            }
            if (e.KeyChar == '7')
            {
                this.button8.PerformClick();
            }
            if (e.KeyChar == '8')
            {
                this.button9.PerformClick();
            }
            if (e.KeyChar == '9')
            {
                this.button10.PerformClick();
            }
            if (e.KeyChar == '+')
            {
                this.button14.PerformClick();
            }
            if (e.KeyChar == '-')
            {
                this.button15.PerformClick();
            }
            if (e.KeyChar == '*')
            {
                this.button16.PerformClick();
            }
            if (e.KeyChar == '/')
            {
                this.button18.PerformClick();
            }
            if (e.KeyChar == '=')
            {
                this.button13.PerformClick();
            }
        }
    }
}