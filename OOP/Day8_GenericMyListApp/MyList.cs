using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMyListApp
{
    class MyList<t>
    {
        private t[] array;
        public MyList()
        {
            array = new t[3];

        }
        public t this[int index]
        {get { return array[index]; }
         set { array[index] = value; }
        }
        public int Length { get { return array.Length; } }
    }
}
