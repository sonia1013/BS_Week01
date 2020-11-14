using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDays_1
{
    public partial class Form1 : Form
    {
        public int intYear;

        public Form1()
        {
            InitializeComponent();
            

        }
        //放入年=>產生? 
        bool leapyear;
        int FirstDay;
        int LastDay;
        int Date;
        int CountSats = 0;
        int CountSuns = 0;

        //private void GetTimeData()
        //{
        //    //判斷是否為閏年
        //    leapyear = DateTime.IsLeapYear(intYear);
        //    DateTime FirstDayValue = new DateTime(intYear, 1, 1);
        //    DateTime LastDayValue = new DateTime(intYear, 12, 31);
        //    //取得當年1/1星期幾
        //    FirstDay = (int)FirstDayValue.DayOfWeek;
        //    //取得當年12/31星期幾
        //    LastDay = (int)LastDayValue.DayOfWeek;
        //}

        private void AllDates()//For迴圈(1/1=>12/31)
        {
            CountSats = 0;
            CountSuns = 0;

            intYear = Int32.Parse(textBox1.Text);
            //leapyear = DateTime.IsLeapYear(intYear);
            for (int i=1;i<=12;i++)
            {
                for(int j=1;j<=31;j++)
                {
                    try
                    {
                        DateTime dt = new DateTime(intYear, i, j);
                        Date = (int)dt.DayOfWeek;
                        if (Date == 6)
                        {
                            CountSats++;                         
                        }
                        if(Date==0)
                        {
                            CountSuns++;
                        }
                    }
                    catch (Exception e)
                    { }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllDates();
            MessageBox.Show("星期六"+CountSats.ToString()+"天");
            MessageBox.Show("星期日"+CountSuns.ToString()+"天");
        }

        private void SatsCount_Click(object sender, EventArgs e)
        {

        }
    }


}
