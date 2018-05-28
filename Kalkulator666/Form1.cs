using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator666
{
    public partial class Kalkulator : Form
    {
        private string temp;
        public string text1;
        public string text2;
        public char sign;

        public Kalkulator()
        {
            InitializeComponent();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.ResetText();
            textBox1.AppendText("0");
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.ResetText();
            textBox1.AppendText("1");
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.ResetText();
            textBox1.AppendText("2");
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.ResetText();
            textBox1.AppendText("3");
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.ResetText();
            textBox1.AppendText("4");
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.ResetText();
            textBox1.AppendText("5");
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.ResetText();
            textBox1.AppendText("6");
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.ResetText();
            textBox1.AppendText("7");
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.ResetText();
            textBox1.AppendText("8");
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.ResetText();
            textBox1.AppendText("9");
        }

        private void button_Coma_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
                textBox1.AppendText("0,");
            else
                textBox1.AppendText(",");
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == string.Empty)
            {
                textBox2.AppendText(textBox1.Text);
                textBox2.AppendText("+");
                textBox1.ResetText();
            }
            else if(textBox1.Text == string.Empty && (textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") || textBox2.Text.EndsWith("/")))
            {
                text2 = textBox2.Text;
                text2 = text2.Remove(text2.Length-1);
                textBox2.ResetText();
                textBox2.AppendText(text2);
                textBox2.AppendText("+");
            }
            else if (textBox1.Text == string.Empty)
            {
                textBox2.AppendText("+");
            }
            else if (textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") || textBox2.Text.EndsWith("/"))
            {
                text2 = textBox2.Text;
                sign = text2.Last<char>();
                text2 = text2.Remove(text2.Length-1);
                text1 = textBox1.Text;
                temp = Calculate.Equals(text2, text1, sign);
                textBox2.ResetText();
                textBox2.AppendText(temp);
                textBox2.AppendText("+");
                textBox1.ResetText();
            }
        }

        private void button_Subtra_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                if (textBox1.Text == "0" || textBox1.Text == string.Empty)
                {
                    textBox2.AppendText("0-");
                    textBox1.ResetText();
                }
                else if (textBox1.Text != string.Empty)
                {
                    textBox2.AppendText(textBox1.Text);
                    textBox2.AppendText("-");
                    textBox1.ResetText();
                }                
            }
            else if (textBox1.Text == string.Empty)
            {
                if (textBox2.Text == string.Empty)
                {
                    textBox2.AppendText("0-");
                }
                else if (textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") || textBox2.Text.EndsWith("/"))
                {
                    text2 = textBox2.Text;
                    text2 = text2.Remove(text2.Length - 1);
                    textBox2.ResetText();
                    textBox2.AppendText(text2);
                    textBox2.AppendText("-");
                }
                else
                {
                    textBox2.AppendText("-");
                }
            }
            else if (textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") || textBox2.Text.EndsWith("/"))
            {
                text2 = textBox2.Text;
                sign = text2.Last<char>();
                text2 = text2.Remove(text2.Length - 1);
                text1 = textBox1.Text;
                temp = Calculate.Equals(text2, text1, sign);
                textBox2.ResetText();
                textBox2.AppendText(temp);
                textBox2.AppendText("-");
                textBox1.ResetText();
            }
        }

        private void button_Multi_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                textBox2.AppendText(textBox1.Text);
                textBox2.AppendText("*");
                textBox1.ResetText();
            }
            else if (textBox1.Text == string.Empty && (textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") || textBox2.Text.EndsWith("/")))
            {
                text2 = textBox2.Text;
                text2 = text2.Remove(text2.Length - 1);
                textBox2.ResetText();
                textBox2.AppendText(text2);
                textBox2.AppendText("*");
            }
            else if (textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") || textBox2.Text.EndsWith("/"))
            {
                text2 = textBox2.Text;
                sign = text2.Last<char>();
                text2 = text2.Remove(text2.Length - 1);
                text1 = textBox1.Text;
                temp = Calculate.Equals(text2, text1, sign);
                textBox2.ResetText();
                textBox2.AppendText(temp);
                textBox2.AppendText("*");
                textBox1.ResetText();
            }
            else if (textBox1.Text == string.Empty)
            {
                textBox2.AppendText("*");
            }
        }

        private void button_Div_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                textBox2.AppendText(textBox1.Text);
                textBox2.AppendText("/");
                textBox1.ResetText();
            }
            else if (textBox1.Text == string.Empty && (textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") || textBox2.Text.EndsWith("/")))
            {
                text2 = textBox2.Text;
                text2 = text2.Remove(text2.Length - 1);
                textBox2.ResetText();
                textBox2.AppendText(text2);
                textBox2.AppendText("/");
            }
            else if (textBox1.Text == string.Empty)
            {
                textBox2.AppendText("/");
            }
            else if (textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") || textBox2.Text.EndsWith("/"))
            {
                text2 = textBox2.Text;
                sign = text2.Last<char>();
                text2 = text2.Remove(text2.Length - 1);
                text1 = textBox1.Text;
                temp = Calculate.Equals(text2, text1, sign);
                textBox2.ResetText();
                textBox2.AppendText(temp);
                textBox2.AppendText("/");
                textBox1.ResetText();
            }
        }

        private void button_Equal_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                /*if (textBox1.Text == string.Empty) ;
                else
                {
                    textBox2.AppendText(textBox1.Text);
                    textBox1.ResetText();
                }*/
            }
            else if (textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") || textBox2.Text.EndsWith("/"))
            {
                if (textBox1.Text == string.Empty)
                {
                    text2 = textBox2.Text;
                    sign = text2.Last<char>();
                    text2 = text2.Remove(text2.Length - 1);
                    text1 = "0";
                    temp = Calculate.Equals(text2, text1, sign);
                    textBox2.ResetText();
                    textBox1.ResetText();
                    textBox1.AppendText(temp);
                }
                else
                {
                    text2 = textBox2.Text;
                    sign = text2.Last<char>();
                    text2 = text2.Remove(text2.Length - 1);
                    text1 = textBox1.Text;
                    temp = Calculate.Equals(text2, text1, sign);
                    textBox2.ResetText();
                    textBox1.ResetText();
                    textBox1.AppendText(temp);
                }
            }
        }

        private void button_Del_Click(object sender, EventArgs e)
        {   if (textBox1.Text != string.Empty)
            {
                text1 = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox1.ResetText();
                textBox1.AppendText(text1);
            }
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "666")
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"./666.wav");
                player.Play();
                MessageBox.Show("The number of the beast!");
            }
           
        }

     }
}