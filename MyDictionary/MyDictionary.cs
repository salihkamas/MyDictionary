using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;
        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }
        public void Add(K key,V value)
        {

            for (int i = 0; i < keys.Length; i++)
            {
                if (i.Equals(key))
                {
                    Console.WriteLine("Bu anahtar başka bir eleman tarafından kullanılıyor.");
                    return;
                }
            }
            K[] tempK = keys;
            V[] tempV = values;
            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempK.Length; i++)
            {
                keys[i] = tempK[i];
                values[i] = tempV[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public int Length
        {
            get { return keys.Length; }
        }
        public K[] Keys
        {
            get { return keys; }
        }
        public V[] Values
        {
            get { return values; }
        }
    }
}
