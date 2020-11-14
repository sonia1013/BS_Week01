using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerAndRiver
{
    public partial class Form1 : Form
    {
        private List<string> animals;
        private List<string> animals_changed;
        private List<string> show_result;

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("農夫要過河囉!");
            CreateList();
            SetListDataSource();
            CrossRiver();
        }

        //創建農夫與動物們
        //建立條件:

        //狼會吃羊:
        private bool WolfMeetsSheep(List<string> vs)
        {
            if (vs.Contains("狼") && vs.Contains("羊"))
            {
                textResult.Text += "狼把羊吃掉了，請重新開始";
                return true;
            }
            else
            {
                return false;
            }
        }
        //羊會吃草
        private bool SheepMeetsVeg(List<string> vs)
        {
            if(vs.Contains("羊") && vs.Contains("菜"))
            {
                textResult.Text += "羊把菜吃掉了，請重新開始";
                return true;
            }
            else
            {
                return false;
            }

        }

        //上一部:儲存每一步的狀態，根據上一步的狀態把物件移過去or用stack
        private void CreateList()
        {
            animals = new List<string>{"農夫","狼","羊","菜"};
            animals_changed = new List<string> { };
        }

        private bool IfFarmerExists(List<string> li)
        {
            if (li.Contains("農夫"))
                return true;
            else
            {
                MessageBox.Show("農夫不在這裡，不能搬東西");
                return false;
            }
        }

        private bool Success(List<string> li)
        {
            //MessageBox.Show(li.Count.ToString());
            if (li.Count == 0)
            {
                textResult.Text += "遊戲勝利";
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SetListDataSource()
        {
            LeftSide.SelectionMode = SelectionMode.One;
            RightSide.SelectionMode = SelectionMode.One;
        }
        private void CrossRiver()
        {
            LeftSide.DataSource = null;
            RightSide.DataSource = null;
            RightSide.DataSource = animals_changed;
            LeftSide.DataSource = animals;
        }

        private void ToRight_Click(object sender, EventArgs e)
        {
            if (IfFarmerExists(animals))
            {
                if (LeftSide.SelectedItem != null)
                {
                    string item = (string)LeftSide.SelectedItem;
                    animals.Remove(item);
                    animals_changed.Add(item);
                    textResult.Text += (string)LeftSide.SelectedItem + "到右岸了\r\n";
                    if (item != "農夫")
                    {
                        animals.Remove("農夫");
                        animals_changed.Add("農夫");
                    }
                    CrossRiver();
                    SheepMeetsVeg(animals);
                    WolfMeetsSheep(animals);
                    Success(animals);
              
                }
            }
        }

        private void ToLeft_Click(object sender, EventArgs e)
        {
            if (IfFarmerExists(animals_changed))
            {
                if (RightSide.SelectedItem != null)
                {
                    string item = (string)RightSide.SelectedItem;
                    animals_changed.Remove(item);
                    animals.Add(item);
                    textResult.Text += (string)RightSide.SelectedItem + "到左岸了\r\n";
                    if (item != "農夫")
                    {
                        animals_changed.Remove("農夫");
                        animals.Add("農夫");
                    }
                    CrossRiver();
                    SheepMeetsVeg(animals_changed);
                    WolfMeetsSheep(animals_changed);
                }
            }
        }
    }
}
