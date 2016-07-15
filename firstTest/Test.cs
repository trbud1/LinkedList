using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTest
{
    class Test
    {
        public Random r;
        public ArrayList array;
        public LinkedList<int> linkedList;
        Stopwatch sw; 

        public Test()
        {
            r = new Random();
            array = new ArrayList();
            linkedList = new LinkedList<int>();
            sw = new Stopwatch();

          
        }

        //= new ArrayList();


        public void SequentialInsert(int size)
        {
            sw.Start();
            for (int k = 0; k < size; k++)
            {
                linkedList.add(k);
            }
            Console.WriteLine("Sequential search. {0} records using LINKED LIST: {1} seconds", size, sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (int k = 0; k < size; k++)
            {
                array.Add(new Node<int>(k));
            }
            sw.Stop();
            Console.WriteLine("Sequential search. {0} records using ARRAYLIST: {1} seconds", size, sw.Elapsed);
            Console.WriteLine("--------------");
        }

        public void NonSequentialInsert(int size)
        {
            sw.Start();
            for (int k = 0; k < size; k++)
            {
                linkedList.addNodeAt(r.Next(0, linkedList.size), new Node<int>(k));
            }
            Console.WriteLine("Non-Sequential search. {0} records using LINKED LIST: {1} seconds", size, sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (int k = 0; k < size; k++)
            {
                array.Insert(r.Next(0, linkedList.size), new Node<int>(k));
            }
            sw.Stop();
            Console.WriteLine("Non-Sequential search. {0} records using ARRAYLIST: {1} seconds", size, sw.Elapsed);
            Console.WriteLine("--------------");
        }

        public void readRecords(int size)
        {

            int i = 0;
            for (int k = 0; k < size; k++)
            {
                linkedList.addNodeAt(r.Next(0, linkedList.size), new Node<int>(k));
            }
            for (int k = 0; k < size; k++)
            {
                array.Insert(r.Next(0, linkedList.size), new Node<int>(k));
            }


            sw.Start();
            foreach (var item in linkedList)
            {
                item.ToString();
                i++;
            }
            sw.Stop();
            Console.WriteLine("Read {0} records using LINKED LIST: {1} seconds", size, sw.Elapsed);
            sw.Reset();
            sw.Start();
            foreach (var idfs in array)
            {
                idfs.ToString();
            }
            sw.Stop();
            Console.WriteLine("Read {0} records using ARRAYLIST: {1} seconds", size, sw.Elapsed);
            Console.WriteLine("--------------");
        }

    }
}
