using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator01
{
    class MyData
    {
        private int _x;
        private int _y;
        public int X { get; set; }
        public int Y { get; set; }
        /*
         public X
        {
        get{return _x;}
        set{_x = value;}
        }
        
         public Y
        {
        get{return _y;}
        set{_y = value;}
        }
         */

        public int Add()
        {
            return X + Y;
        }

        public int Minus()
        {
            return X - Y;
        }
    }




    //}
    //屬性的本質是方法 ,是用來存取欄位的途徑
    //////使用屬性成為公開public介面:C#習慣公開屬性而不是欄位
    //get是屬性，取得值
    //set是賦予值


}
