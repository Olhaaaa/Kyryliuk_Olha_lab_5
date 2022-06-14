using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxx_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
    "Ви дійсно хочете вийти із форми?",
    "Завершення програми", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            switch (rand.Next(0, 13))
            {
                case 0: button2.BackColor = Color.Red; break;
                case 1: button2.BackColor = Color.Green; break;
                case 2:
                    button2.BackColor = Color.Yellow;
                    try
                    {
                        double b = Convert.ToDouble(textBoxb.Text);
                        double c = Convert.ToDouble(textBoxc.Text);
                        double a = Convert.ToDouble(textBoxa.Text);
                        double firstfunction = (Math.Sin(2 * a) / a) - (3 + Math.Atan(b) / c);

                        if (a == 3 || c == 0)
                        {
                            textBox1.Text = "Введіть допустимі значення!";
                        }
                        else
                        {

                            textBox1.Text = Convert.ToString(firstfunction);
                        }
                    }
                    catch
                    {
                        textBox1.Text = "Введіть числові значення";
                    }

                    break;
                case 3: button2.BackColor = Color.White; break;
                case 4: button2.BackColor = Color.Gray; break;
                case 5: button2.BackColor = Color.Blue; break;
                case 6: button2.BackColor = Color.Cyan; break;
                case 7: button2.BackColor = Color.DarkBlue; break;
                case 8: button2.BackColor = Color.DarkCyan; break;
                case 9: button2.BackColor = Color.DarkGray; break;
                case 10: button2.BackColor = Color.DarkBlue; break;
                case 11: button2.BackColor = Color.DarkRed; break;
                case 12: button2.BackColor = Color.DarkOrange; break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            switch (rand.Next(0, 13))
            {
                case 0: button1.BackColor = Color.Red; break;
                case 1: button1.BackColor = Color.Green; break;
                case 2: button1.BackColor = Color.Yellow; break;
                case 3:
                    button1.BackColor = Color.White;
                    try
                    {
                        double a = Convert.ToDouble(textBoxa.Text);
                        double b = Convert.ToDouble(textBoxb.Text);
                        double c = Convert.ToDouble(textBoxc.Text);
                        double x = Convert.ToDouble(textBoxx.Text);
                        double secondfunction = Math.Sign(x - 2 * a) + Math.Log(3, x / a);

                        if (a == 0 || x / a <= 0)
                        {
                            textBox2.Text = "Введіть допустимі значення!";
                        }
                        else
                        {
                            // secondfunction = (Math.Sin(2 * a) / a) - (3 + Math.Atan(b) / c);
                            textBox2.Text = Convert.ToString(secondfunction);
                        }
                    }
                    catch
                    {
                        textBox2.Text = "Введіть числові значення";
                    }

                    break;
                case 4: button1.BackColor = Color.Gray; break;
                case 5: button1.BackColor = Color.Blue; break;
                case 6: button1.BackColor = Color.Cyan; break;
                case 7: button1.BackColor = Color.DarkBlue; break;
                case 8: button1.BackColor = Color.DarkCyan; break;
                case 9: button1.BackColor = Color.DarkGray; break;
                case 10: button1.BackColor = Color.DarkBlue; break;
                case 11: button1.BackColor = Color.DarkRed; break;
                case 12: button1.BackColor = Color.DarkOrange; break;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
