using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Calculation
{
    public partial class Calculation : Form
    {
        public float result = 0;
        public float number = 0, number2 = 0;
        public int choose = -1, choose2;
        public string str;
        
        public Calculation()
        {
            
            InitializeComponent();
            checkBox1.Image = Properties.Resources.Funktions_ADD;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Numbers("1");  
        }

        private void IS_Click(object sender, EventArgs e)
        {
            Calculate();
        }
        private void button19_Click(object sender, EventArgs e)
        {
            number = 0;
            number2 = 0;
            result = 0;
            textBox1.Clear();
            label1.Text = "0";
            choose = -1;
        }
        private void ADD_Click(object sender, EventArgs e)
        {
            Calculate();
            if (textBox1.Text == "")
            {
                choose = -1;
                textBox1.Text = Convert.ToString(result);
                result = 0;
            }
            if (choose == -1)
            {
                NUM1();
                result = 0;
                result +=number;
                choose = 1;
                number = 0;
                textBox1.Clear();
            }
            else
            {
                NUM2();
                result += number2;
                textBox1.Clear();
            }
            label1.Text = Convert.ToString(result) + "+";
        }
        private void SUM_Click(object sender, EventArgs e)
        {
            Calculate();
            if (textBox1.Text == "")
            {
                choose = -1;
                textBox1.Text = Convert.ToString(result);
                result = 0;
            }
            if (choose == -1)
            {
                NUM1();
                result = 0;
                result += number;
                choose = 2;
                number = 0;
                textBox1.Clear();
            }
            else
            {
                NUM2();
                result -= number2;
                textBox1.Clear();
            }
            label1.Text = Convert.ToString(result) + "-";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Numbers("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Numbers("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Numbers("4");
        }
        private void Numbers(string str1)
        {
            str = textBox1.Text + str1;
            textBox1.Text = str;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Numbers("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Numbers("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Numbers("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Numbers("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Numbers("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Numbers("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Numbers("00");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Numbers(",");
        }
        public void Calculate()
        {
            switch(choose)
            {
                case 1:
                    if (textBox1.Text == "")
                        textBox1.Text = "0";
                    else
                    {
                        NUM2();
                        result += number2;
                        number2 = 0;
                        label1.Text = "RESULT: " + Convert.ToString(result);

                        textBox1.Clear();
                    }
                    choose = -1;
                    break;
                case 2:
                    if (textBox1.Text == "")
                        textBox1.Text = "0";
                    else
                    {
                        NUM2();
                        result -= number2;
                        number2 = 0;
                        label1.Text = "RESULT: " + Convert.ToString(result);
                        textBox1.Clear();
                    }
                    choose = -1;
                    break;
                case 3:
                    if (textBox1.Text == "")
                        textBox1.Text = "1";
                    else
                    {
                        NUM2();
                        result *= number2;
                        number2 = 0;
                        label1.Text = "RESULT: " + Convert.ToString(result);
                        textBox1.Clear();
                    }
                    choose = -1;
                    break;
                case 4:
                    if (textBox1.Text == "")
                        textBox1.Text = "1";
                    else
                    {
                        NUM2();
                        result /= number2;
                        number2 = 0;
                        label1.Text = "RESULT: " + Convert.ToString(result);
                        textBox1.Clear();
                    }
                    choose = -1;
                    break;
                case 5: 
                    label1.Text = "RESULT: " + Convert.ToString(result);
                    choose = -1;
                    break;
                case 6:
                    if (textBox1.Text == "")
                        textBox1.Text = "0";
                    else
                    {
                        NUM2();
                        result = (float)Math.Pow(result,number2);
                        number2 = 0;
                        label1.Text = "RESULT: " + Convert.ToString(result);
                        textBox1.Clear();
                    }
                    choose = -1;
                    break;
                case 7:
                    label1.Text = "RESULT: " + Convert.ToString(result);
                    choose = -1;
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox1.Size = new Size(508, 86);
                this.Width = 544;
                checkBox1.Image = Properties.Resources.Funktions_SUB;
            }
            else
            {
                textBox1.Size = new Size(360, 86);
                this.Width = 404;
                checkBox1.Image = Properties.Resources.Funktions_ADD;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Calculate();
            if (textBox1.Text == "")
            {
                choose = -1;
                textBox1.Text = Convert.ToString(result);
                result = 0;
            }
            if (choose == -1)
            {
                NUM1();
                result = 0;
                result += number;
                choose = 3;
                number = 0;
                textBox1.Clear();
            }
            else
            {
                NUM2();
                result *= number2;
                textBox1.Clear();
            }
            label1.Text = Convert.ToString(result) + "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Calculate();
            if (textBox1.Text == "")
            {
                choose = -1;
                textBox1.Text = Convert.ToString(result);
                result = 0;
            }
            if (choose == -1)
            {
                NUM1();
                result = 0;
                result += number;
                choose = 4;
                number = 0;
                textBox1.Clear();
            }
            else
            {
                NUM2();
                result /= number2;
                textBox1.Clear();
            }
            label1.Text = Convert.ToString(result) + "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            Calculate();
            choose = 5;
            if (textBox1.Text == "")
            {
                choose = -1;
                textBox1.Text = Convert.ToString(result);
                result = 0;
            }
            NUM1();
            result = 0;
            result = (float)Math.Sqrt(number);
            
            number = 0;
            textBox1.Clear();
            label1.Text = Convert.ToString(result) + "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Calculate();
            if (textBox1.Text == "")
            {
                choose = -1;
                textBox1.Text = Convert.ToString(result);
                result = 0;
            }
            if (choose == -1)
            {
                NUM1();
                result = 0;
                result += number;
                choose = 6;
                number = 0;
                textBox1.Clear();
            }
            else
            {
                NUM2();
                result = (float)Math.Pow(result, number2);
                textBox1.Clear();
            }
            label1.Text = Convert.ToString(result) + "^";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = "0";
                result = 0;
            }
            else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3,14159";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Calculate();
            choose = 7;
            if (textBox1.Text == "")
                textBox1.Text = Convert.ToString(result);
            number = float.Parse(textBox1.Text);
            result = (float)Math.Cos(number);
            label1.Text = "Cos(" + number + ")"+ "=" + Convert.ToString(result);
            textBox1.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Calculate();
            choose = 7;
            if (textBox1.Text == "")
                textBox1.Text = Convert.ToString(result);
            number = float.Parse(textBox1.Text);
            result = (float)Math.Sin(number);
            label1.Text = "Sin(" + number + ")" + "=" + Convert.ToString(result);
            textBox1.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Calculate();
            choose = 7;
            if (textBox1.Text == "")
                textBox1.Text = Convert.ToString(result);
            number = float.Parse(textBox1.Text);
            result = (float)Math.Tan(number);
            label1.Text = "Tan(" + number + ")" + "=" + Convert.ToString(result);
            textBox1.Clear();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Program AP = new About_Program();
            AP.Show();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                ADD_Click(sender, e);
            }
            
            if (e.KeyCode == Keys.Subtract)
            {
                SUM_Click(sender, e);
            }
            if (e.KeyCode == Keys.Divide)
            {
                button16_Click(sender, e);
            }            
            if (e.KeyCode == Keys.Multiply)
            {
                button15_Click(sender, e);
            }
            if (e.KeyCode == Keys.Enter)
            {
                IS_Click(sender, e); 
            }
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "/" || textBox1.Text == "*")
                textBox1.Clear();

        }
        private void NUM1()
        {
            try
            {
                number = float.Parse(textBox1.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("ERROR!!! Enter the numeric!!!", "Format Exception",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                result = 0;
                number = 0;
                number2 = 0;
            }
        }
        private void NUM2()
        {
            try
            {
                number2 = float.Parse(textBox1.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("ERROR!!! Enter the numeric!!!", "Format Exception",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                result = 0;
                number = 0;
                number2 = 0;
            }
        }
        private void button23_Click(object sender, EventArgs e)
        {
            Calculate();
            choose = 7;
            if (textBox1.Text == "")
                textBox1.Text = Convert.ToString(result);
            number = float.Parse(textBox1.Text);
            result = 1;
            for (int i = 1; i < number + 1; i++)
                result *= i;
            label1.Text =  number + "!" + "=" + Convert.ToString(result);
            textBox1.Clear();
        }
       
    }
}
