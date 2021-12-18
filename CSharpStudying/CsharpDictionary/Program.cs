using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace CsharpDictionary
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable= new Hashtable();
            hashtable.Add(30, "겜발코인");
            hashtable.Add(1, "스뜨링");
            hashtable.Add(20, "스뜨링");
            hashtable.Add(2, "농상");

            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine(key.GetHashCode());
                Console.WriteLine(hashtable[key].GetHashCode());
            }
            
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(10, "스뜨링");
            dictionary.Add(20, "꽃공명");
            dictionary.Add(3, "겜발코인");
            dictionary.Add(2, "농상");
            

            foreach (var kvp in dictionary)
            {
                Console.WriteLine(kvp.Key.GetHashCode());
                Console.WriteLine(kvp.Value.GetHashCode());
            }
            

            // var dict = new ConcurrentDictionary<int, string>();
            //
            // Task t1 = Task.Factory.StartNew(() =>
            // {
            //     int key = 1;                
            //     while (key <= 100)
            //     {
            //         if (dict.TryAdd(key, "D" + key))
            //         {
            //             key++;
            //         }
            //         Thread.Sleep(100);
            //     }
            // });
            //
            // Task t2 = Task.Factory.StartNew(() =>
            // {
            //     int key = 1;
            //     string val;
            //     while (key <= 100)
            //     {
            //         if (dict.TryGetValue(key, out val))
            //         {
            //             Console.WriteLine("{0},{1}", key, val);
            //             key++;
            //         }
            //         Thread.Sleep(100);
            //     }
            // });
            //
            // Task.WaitAll(t1, t2);
        }
    }
}

