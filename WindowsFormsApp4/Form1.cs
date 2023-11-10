using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int input = Convert.ToInt32(textBox1.Text);
                int result = 1;

                if (input < 0)
                {
                    MessageBox.Show("Value is less than 0");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else {

                    for (int i = 1; i <= input; i++)
                    {
                        result *= i;
                    }

                    if(input == 0)
                    {
                        textBox2.Text = Convert.ToString(0);
                    }
                    else
                    {
                        textBox2.Text = Convert.ToString(result);
                    }
                    
                }
 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
