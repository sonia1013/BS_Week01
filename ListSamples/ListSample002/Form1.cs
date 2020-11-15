﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample002
{
    public partial class Form1 : Form
    {

        private List<MyRectangle> _list;
        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetCombobox();
        }

        private void CreateList()
        {
            _list = new List<MyRectangle>()
            {
                new MyRectangle { Name = "D1", Width = 5, Height = 5 },
                new MyRectangle { Name = "D2", Width = 10, Height = 10 },
                new MyRectangle { Name = "D3", Width = 20, Height = 20 },
                new MyRectangle { Name = "D4", Width = 100, Height = 100 }
            };
        }
        private void SetCombobox()
        {
            comboBox1.DataSource = _list;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Area";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // SelectedItem 還是 MyRectangle
            int area = (int)comboBox1.SelectedValue;            
            MessageBox.Show(area.ToString());

        }
    }
}
