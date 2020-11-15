using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator03
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }



        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int Result = 0;
            label1.Text= Result.ToString();

            //switch(domainUpDown1.SelectedIndex)
            //{
            //    case 1:
            //        {
            //            Result = x + y;
            //            break;
            //        }
            //    case 2:
            //        {
            //            Result = x - y;
            //            break;
            //        }
            //    case 3:
            //        {
            //            Result = x * y;
            //            break;
            //        }
            //    default:
            //        {
            //            Result = x / y;
            //            break;
            //        }
            }
        }
    }

