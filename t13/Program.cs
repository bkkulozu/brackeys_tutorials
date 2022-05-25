﻿using System;
using System.Collections.Generic;


//generics
namespace ConsoleProjectGenerics{

    class Program {

        public static void Main(string[] args)
        {
            KeyValuePair<string, int> meaning = new KeyValuePair<string, int> ("Life", 42);
            meaning.Print();

            Console.ReadKey();

        }

    }

        class KeyValuePair<TKey, TValue>
        {
            public TKey key;
            public TValue value;

            public KeyValuePair(TKey _key, TValue _value)
            {
                 key= _key;
                 value = _value;

            }

            public void Print()
            {
                Console.WriteLine("Key : " + key.ToString());
                Console.WriteLine("Value : " + value.ToString());
                
             }
        }
    }