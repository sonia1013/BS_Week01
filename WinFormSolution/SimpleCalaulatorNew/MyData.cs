using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalaulatorNew
{

        class MyData
        {

            public int X { get; set; }
            public int Y { get; set; }
            public int Add()
            {
                return X + Y;
            }

            public int Minus()
            {
                return X - Y;
            }
        }
    }
