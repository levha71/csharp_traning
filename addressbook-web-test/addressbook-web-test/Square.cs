using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_test
{
    class Square : Figure
    {
        private int size;
        

        public Square(int size)
        {
            this.size = size; //В поле присваиваем значение которое переданно в качестве параметра
        }

        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }


    } 
}
