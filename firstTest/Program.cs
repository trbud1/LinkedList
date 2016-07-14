using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTest
{
    class Program
    {
        static void Main(string[] args)
        { 
            Game g = new Game();
            g.gameMenu();
        }
    }

 

    public class Node{

        public object value;
        public Node next;

        public Node(object value)
        {
            this.value = value;
            next = null;
        }

        
    }

    public class LinkedList
    {
        Node head;
        public int size = 1;

        public void addNodeEnd(string name)
        {

            Node newNode = new Node(name);
            Node currentHead = this.head;

            while (true)
            {
                if(currentHead.next == null)
                {
                    currentHead.next = newNode;
                    break;
                }
                currentHead = currentHead.next;
            }
            this.size++;

        }
        public void addNodeStart()
        {

            //Node newNode = new Node(GetName());
            Node newNode = new Node("xzcz");
            Node tmp = head;
            newNode.next = head;
            head = newNode;
            this.size++;
        }

        public void add(string aValue)
        {

            Node newNode = new Node(aValue);
            Node tmp = head;

            newNode.next = head;
            head = newNode;
            this.size++;
        }

        public void addNodeAt(int pos, Node newNode)
        {
            Node curHead = head;

            for (int i = 0; i < pos-1 ; i++)
            {

                curHead = curHead.next;
            }

            if (pos == 0)
            {
                Node temp = head;
                head = newNode;
                newNode.next = temp;
            }
            else
            {
                Node next = curHead.next;
                curHead.next = newNode;
                newNode.next = next;
            }

        }




        public void removeNode(int pos)
        {
            if (pos == -1)
            {
                Console.WriteLine("Enter index to delete: ");
                pos = int.Parse(Console.ReadLine());
            }

            //if valid index
            if (pos >= 0 && pos <= this.size-1)
            {
                Node cur = head;
                
                for (int i = 0; i < pos - 1; i++)
                {
                    //Console.WriteLine("position: {0}", pos);
                    //Console.Read();
                    cur = cur.next;
                }
                
                if(pos == 0)
                {
                    head = cur.next;
                }


                else if (cur.next.next != null)
                {
                    cur.next = cur.next.next;
                    //head = cur.next;
                }
                else if (cur.next.next == null)
                {
                    cur.next = null;
                }
                this.size--;
            }else
            {
                Console.WriteLine("Not a valid value");
            }
        }
        
       
        public void PrintNodes()
        {
            Node cur = head;
            int i = 0;
            //Console.WriteLine("cur: {0}", cur.value);
            while (cur != null)
            {
                if(cur.next == null)
                {
                    Console.WriteLine("{0}. {1} --> null", i, cur.value);
                }else
                {
                    Console.Write("{0}. {1} -->", i, cur.value);
                }
                i++;
                cur = cur.next;
            }

            Console.WriteLine("Size: {0}\n", this.size-1);
        }
    }
}
