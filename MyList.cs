using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__OOP
{
    class MyList<T>
    {
        T[] items;

        //constructor
        public MyList()
        {
            items = new T[0];
        }

        //Add Method
        public void Add(T item)
        {
            T[] tempArray= items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length-1] = item;
        }

        //Length Method
        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items { get { return items; } }
    }
}
