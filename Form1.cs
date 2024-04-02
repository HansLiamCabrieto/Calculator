using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)//tool
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//tool
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//tool
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//tool
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//tool
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)//tool
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)//tool
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)//tool
        {

        }

        private void button1_Click(object sender, EventArgs e)//tool
        {
            int a = 0 + Convert.ToInt32(textBox1.Text);//collects and saves number 1 as a
            int b = 0 + Convert.ToInt32(textBox2.Text);//collects abd saves number 2 as b
            int c;//The Answer

            if (radioButton1.Checked)//checks at radion button 1 is checked
            {
                c = a + b;//The answer will be a+b
                label4.Text = "Total = " + c.ToString();//Prints answer to label 4
            }
            else if (radioButton2.Checked)//Checks if radio button 2 is checked
            {
                c = a - b;//The answer will be a-b
                label4.Text = "Difference = " + c.ToString();//Prints answer to label 4

            }
            else if (radioButton3.Checked)//Checks if radio button 3 is checked
            {
                c = a * b;//The answer will be a*b
                label4.Text = "Product = " + c.ToString();//Prints answer to label 4
            }
            else if (radioButton4.Checked)//Checks if radio button 4 is checked
            {
                c = a / b;//the answer will be a/b
                label4.Text = "Quotient = " + c.ToString();//Prints answer to label 4
            }
            else if (radioButton5.Checked)//Checks if radio button 5 is checked
            { c = a % b;//The answer will be a%b
                label4.Text = "Remainder = " + c.ToString();//Prints answer to label 4

            }
            else
            { label4.Text = "Please Choose one of the Options";//Prints to label 4 if nothing is checked
            
            }
        }

        private void button2_Click(object sender, EventArgs e)//tool
        {
            label4.Text = "Answer";//Changes label 4 to "Answer"
            textBox1.Clear();//Clears textbox 1
            textBox2.Clear();//clears textbox 2

        }

        private void button1_MouseHover(object sender, EventArgs e)//tool
        {
            button1.BackColor = Color.Green;//Changes button color to Green when mouse hovers on button 1


        }

        private void button1_MouseLeave(object sender, EventArgs e)//tool
        {
            button1.BackColor = Color.White;//Changes button color to white when mouse leaves button 1
        }

        private void button2_MouseHover(object sender, EventArgs e)//tool
        {
            button2.BackColor = Color.Red;//Changes button color to red when mouse hovers on button 2

        }


        private void button2_MouseLeave(object sender, EventArgs e)//tool
        {
            button2.BackColor = Color.White;//Changes button color to white when mouse leves button 2
        }
    }
}
