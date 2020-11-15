using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        //private void Calculate(bool condition)
        //{
        //    int x = int.Parse(textBox1.Text);
        //    int y = int.Parse(textBox2.Text);

            
        //    if(!condition)
        //    {
        //        y = -y;
        //    }

        //    label1.Text = (x + y).ToString();
        //}



        private void button1_Click(object sender, EventArgs e)
        {
            //Calculate(true);
            Compute(true);
        }

        private void Compute(bool v)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            label1.Text = (x + y).ToString();

            if(!v)
            {
                y = -y;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Calculate(false);
        }


    }
}
