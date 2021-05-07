using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_IndexerTestApp
{
    class MyList: IEnumerable, IEnumerator
    {
        private int[] array;
        private int position = -1;

        public int this[int index]//this+꺾쇠- 인덱서! //MyList[i] array의 i번째 값을 가져오겠다
        {
            get
            {
                return array[index];

            }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize(ref array, index + 1);
                    Console.WriteLine($"size 증가.{array.Length}");

                }
                array[index] = value;
            }

        }
        public int Length
        {
            get { return array.Length; }
        }

        public object Current
        {
            get { return array[position]; }///현재값 foreach 에만 필요.
        }


        public MyList()
        {
            array = new int[3];
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            position = position + 1;
            return (position < array.Length);
        }

        public void Reset()
        {
            position = -1;//초기화
        }
    }
}
