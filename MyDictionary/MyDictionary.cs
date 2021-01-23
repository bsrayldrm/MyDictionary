using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TValue,TKey>
    {
        TValue[] item1;
        TKey[] item2;
    public MyDictionary()
        {
            item1 = new TValue[0];
            item2 = new TKey[0];

        }
        public void Add(TValue items1, TKey items2)
        {
            TValue[] tempItem1 = item1;
            TKey[] tempItem2 = item2;

            item1 = new TValue[item1.Length + 1];
            item2 = new TKey[item2.Length + 1];


            for (int i = 0; i < tempItem1.Length; i++)
            {
                item1[i] = tempItem1[i];
                item2[i] = tempItem2[i];




            }

            item1[item1.Length - 1] = items1;
            item2[item2.Length - 1] = items2;


        }


        public void GetExam()
        {

            for (int i = 0; i < item1.Length; i++)
            {
                Console.WriteLine(item1[i] + " " + item2[i]);
            }

        }
             
    }
}
