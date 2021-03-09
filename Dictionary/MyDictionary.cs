using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<Key, Value>
    {
        Key[] numberArray;
        Value[] monthArray;

        public MyDictionary()
        {
            numberArray = new Key[0];
            monthArray = new Value[0];
        }

        public void Add(Key number, Value month)
        {
            Key[] tempKeys = numberArray;
            numberArray = new Key[numberArray.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                numberArray[i] = tempKeys[i];
            }

            numberArray[numberArray.Length - 1] = number;


            Value[] tempValue = monthArray;
            monthArray = new Value[monthArray.Length + 1];

            for (int x = 0; x < tempValue.Length; x++)
            {
                 monthArray[x] = tempValue[x];
            }

            monthArray[monthArray.Length - 1] = month;
            
        }

        public void List()
        {
            for (int z = 0; z < numberArray.Length; z++)
            {
                Console.WriteLine("Number" + numberArray[z] + ":" + monthArray[z]);
            }
        }
    }
    }

    

