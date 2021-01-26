using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictonary
{
    class MyDictionary<S>
    {
        S[] items;
        
        public MyDictionary()
        {
            items = new S[0];
        }
           
        public void Add(S item)
        {
            S[] tempArray = items;
            items = new S[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
            Console.WriteLine(item);
        }

    }
}
