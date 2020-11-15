using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form    
    {
        private Dictionary<string, MyRectangle> _dictionary;
        //索引鍵型別：string
        //值型別：MyRectangle
        
        private void CreateDictionary()
        {
            _dictionary = new Dictionary<string, MyRectangle>();
            _dictionary.Add("D1", new MyRectangle { Width = 5,Height=5 });
            _dictionary.Add("D2", new MyRectangle { Width = 10, Height = 10 });
            _dictionary.Add("D3", new MyRectangle { Width = 20, Height = 20 });
            _dictionary.Add("D4", new MyRectangle { Width = 200, Height = 200 });
        }
        
        public Form1()
        {
            InitializeComponent();
            CreateDictionary();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text;
            if(_dictionary.ContainsKey(key))
            {
                int area = _dictionary[key].GetArea();
                MessageBox.Show($"{key}面積為:{area}");
            }
            else
            {
                MessageBox.Show("查無資料");
            }
        }
    }
}
