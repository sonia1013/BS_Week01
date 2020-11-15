using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalaulatorNew
{
    public partial class Form1 : Form
    {
        private MyData _data;
        public Form1()
        {
            InitializeComponent();
            _data = new MyData();
        }

        private void Calculate(bool add)
        {
            _data.X = int.Parse(textBox1.Text);
            _data.Y = int.Parse(textBox2.Text);
            if (add)
            {
                label1.Text = _data.Add().ToString();
            }
            else
            {
                label1.Text = _data.Minus().ToString();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Calculate(true);
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Calculate(false);
        }
    }
}
