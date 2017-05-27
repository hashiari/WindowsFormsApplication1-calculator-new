using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1_calculator_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num, ans;
        int count;
        public void disable()
        {
            // Follow  are disable when call we disable() funtion

            textBox1.Enabled = false;
            button1.Show(); // It will be still Disply
            button2.Hide(); // It will be Hide
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
           
        }
        public void enable() // Now create one function to ON Calculator
        {
            // Follow are Enabled when we call enable() function
            textBox1.Enabled = true;
            button1.Show(); // It will be still Disply
            button2.Hide(); // It will be Hide
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // Displayed dot(.) in Textbox when press dot(.) button with Red Color
            textBox1.Text = textBox1.Text + " . ";
            textBox1.ForeColor = Color.Red;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // Displayed 0 in textbox when press 0 button with Red Color
            textBox1.Text = textBox1.Text + 0;
            textBox1.ForeColor = Color.Red;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Displayed 1 in textbox when press 1 button with Red Color
            textBox1.Text = textBox1.Text + 1;
            textBox1.ForeColor = Color.Red;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Displayed 2 in textbox when press 2 button with Red Color
            textBox1.Text = textBox1.Text + 2;
            textBox1.ForeColor = Color.Red;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Displayed 3 in textbox when press 3 button with Red Color
            textBox1.Text = textBox1.Text + 3;
            textBox1.ForeColor = Color.Red;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Displayed 4 in textbox when press 4 button with Red Color
            textBox1.Text = textBox1.Text + 4;
            textBox1.ForeColor = Color.Red;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Displayed 5 in textbox when press 5 button with Red Color
            textBox1.Text = textBox1.Text + 5;
            textBox1.ForeColor = Color.Red;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Displayed 6 in textbox when press 6 button with Red Color
            textBox1.Text = textBox1.Text + 6;
            textBox1.ForeColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Displayed 7 in textbox when press 7 button with Red Color
            textBox1.Text = textBox1.Text + 7;
            textBox1.ForeColor = Color.Red;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Displayed 8 in textbox when press 8 button with Red Color
            textBox1.Text = textBox1.Text + 8;
            textBox1.ForeColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Displayed 9 in texbox when press 9 button with Red Color
            textBox1.Text = textBox1.Text + 9;
            textBox1.ForeColor = Color.Red;

        }

        private void button2_Click(object sender, EventArgs e) // OFF Button
        {
            disable(); // disable call function to off calculator
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enable(); // call enable() function to ON Calculator
        }

        public void compute()
        {
            switch (count) // createing Switch Stastment
            {

                case 1:

                    ans = num + float.Parse(textBox1.Text); // It preforms addtion
                    textBox1.Text = ans.ToString();  // Converted float  into string
                    break; 

                case 2:

                    ans = num - float.Parse(textBox1.Text);  // It preforms  sbstracti  
                    textBox1.Text = ans.ToString(); 
                    break;

                case 3:

                    ans = num * float.Parse(textBox1.Text); // It preforms multiplication
                    textBox1.Text = ans.ToString();
                    break;

                case 4:
                    ans = num / float.Parse(textBox1.Text); // It performs division
                    textBox1.Text = ans.ToString();
                    break;




            }
            {





            }
        }

        private void button5_Click(object sender, EventArgs e) // Adition Button

        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();  // Clear the textbox
            textBox1.Focus();  // focus on after eaning textbox
            count = 1;   // count store case
            label1.Text = num.ToString() + "+";



        }

        private void button9_Click(object sender, EventArgs e) // subtraction
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear(); // Clear the textbox
            textBox1.Focus(); // Focus on after clearing textbox
            count = 2; // count store case
            label1.Text = num.ToString() + "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            compute(); // call compute() function to perform such operation
            label1.Text = ""; // clear the text on the label
        }

        private void button4_Click(object sender, EventArgs e) // clear button
        {
            textBox1.Text = ""; // clear the text on the textbox

        }

        private void button3_Click(object sender, EventArgs e) // backspace butoon

        {
            int lenght = textBox1.TextLength -1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
                textBox1.Text = textBox1.Text + text[i];
        }

    }
}

