using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace firstTest
{
    class Program
    {   
        public static string ourType;
        public LinkedList<int> linkedList;
        //public LinkedList linkedList;
        static void Main(string[] args)
        {

            Test t = new Test();
            t.SequentialInsert(1500);
            t.NonSequentialInsert(1500);
            t.readRecords(1500);

            //var linkedList = new LinkedList<int>();

            ////TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            ////int start = (int)t.TotalSeconds;
            //Stopwatch sw = new Stopwatch();
            
            //long time = 200000l;
            //Random r = new Random();
            //ArrayList array = new ArrayList();
            //int i = 0;
            //for (int k = 0; k < time; k++)
            //{  
            //    linkedList.addNodeAt(r.Next(0, linkedList.size), new Node<int>(k));
            //}
            //for (int k = 0; k < time; k++)
            //{
            //    array.Insert(r.Next(0, linkedList.size), new Node<int>(k));
            //    //.Add(r.Next(0, 2), new Node<int>(k));
            //}
            //sw.Start();
            //foreach (var item in linkedList)
            //{
            //    item.ToString();
            //    //Console.Write("{0}.{1}--> ", i, item);
            //    i++;
            //}
            ////int end = (int)t.TotalSeconds;
            //sw.Stop();
            //Console.WriteLine("Add {0} records using LINKED LIST: {1} seconds", time, sw.Elapsed);
            //sw.Reset();
            //sw.Start();
            ////t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            ////start = (int)t.TotalSeconds;
           
            //foreach(var idfs in array)
            //{
            //    idfs.ToString();
            //}

            //sw.Stop();
            ////end = (int)t.TotalSeconds;

            //Console.WriteLine("Add 200 records using ARRAYLIST: {0} seconds", sw.Elapsed);

            //linkedList.add(1);
            //linkedList.add(1);
            //linkedList.add(2);
            //linkedList.add(1);
            //linkedList.add(4);
            //linkedList.add(1);

            //do
            //{
            //int i = 0;
            //foreach (var item in linkedList)
            //{
            //    Console.Write("{0}.{1}--> ", i,item);
            //    i++;
            //}

            //    Console.WriteLine("1. Insert at start");
            //    Console.WriteLine("2. Insert at end");
            //    Console.WriteLine("3. Delete at start");
            //    Console.WriteLine("4. Delete at end");



            //} while (true);

            Console.Read();

            //if(args.Count() >= 1)
            //{
            //    switch(args[0])
            //    {
            //        case "string":
            //            new Game<string>().GameMenu();
            //            ourType = "string";
            //            break;
            //        case "int":
            //            ourType = "int";
            //            new Game<int>().GameMenu();
            //            break;
            //        default: // defaults to string
            //            ourType = "string";
            //            new Game<string>().GameMenu();
            //            break;
            //    }
            //}

        }
    }

}
