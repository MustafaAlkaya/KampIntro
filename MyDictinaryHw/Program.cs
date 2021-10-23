using System;

namespace MyDictinaryHw
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictinary<int ,string> dictinary = new MyDictinary<int , string > ();
            dictinary.Add(1, "Mustafa");
            dictinary.Add(2, "Mehmet");
            Console.WriteLine(dictinary.Length);
            dictinary.Add(3, "Abdullah");
            Console.WriteLine(dictinary.Length);
            dictinary.Show();
        }
    }

    class MyDictinary<Tkeys,Tvalue>
    {
        Tkeys[] tKeys = new Tkeys[0];
        Tvalue[] tValues = new Tvalue[0];

        Tkeys[] tempKeys;
        Tvalue[] tempValue;


        public void Add (Tkeys key , Tvalue value)
        {
            tempKeys = tKeys;
            tempValue = tValues;

            tKeys = new Tkeys[tKeys.Length + 1];
            tValues = new Tvalue[tValues.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                tKeys[i] = tempKeys[i];
            }
            for (int i = 0; i < tempValue.Length; i++)
            {
                tValues[i] = tempValue[i];
            }
            tKeys[tKeys.Length - 1] = key;
            tValues[tValues.Length - 1] = value;
        }

        public int Length
        {
            get { return tKeys.Length;}
        }

        public void Show ()
        {
            for (int i = 0; i < tKeys.Length; i++)
            {
                Console.WriteLine("Key = " + tKeys[i] + " Value = " + tValues[i] );
            }
        }
    }
}
