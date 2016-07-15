using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTest
{
    public class Node<T>
    {

        public T value;
        public Node<T> next;

        public Node(T value)
        {
            this.value = value;
            next = null;
        }

    }

    public class LinkedList<T> : ILinkedlist, IEnumerable<T>
    {
        public Node<T> head;
        public int size = 0;

        public void addNodeEnd(T name)
        {

            Node<T> newNode = new Node<T>(name);
            Node<T> currentHead = this.head;

            while (true)
            {
                if (currentHead.next == null)
                {
                    currentHead.next = newNode;
                    break;
                }
                currentHead = currentHead.next;
            }
            this.size++;

        }
        public void addNodeStart(T name)
        {
            Node<T> newNode = new Node<T>(name);
            Node<T> tmp = head;
            newNode.next = head;
            head = newNode;
            this.size++;
        }

        public void add(T aValue)
        {
            Node<T> newNode = new Node<T>(aValue);
            Node<T> tmp = head;
            newNode.next = head;
            head = newNode;
            this.size++;
        }

        public void addNodeAt(int pos, Node<T> newNode)
        {
            Node<T> curHead = head;

            for (int i = 0; i < pos - 1; i++)
            {

                curHead = curHead.next;
            }

            if (pos == 0)
            {
                Node<T> temp = head;
                head = newNode;
                newNode.next = temp;
            }
            else
            {
                Node<T> next = curHead.next;
                curHead.next = newNode;
                newNode.next = next;
            }

        }

        public void removeNode(int pos)
        {
            if (size <= 0)
            {
                showError("No elements to remove");
                return;
            }
            //if valid index
            if (pos >= 0 && pos <= this.size)
            {
                Node<T> cur = head;

                if (this.size == pos)
                {
                    for (int i = 0; i < pos - 2; i++)
                    {
                        //Console.WriteLine("position: {0}", pos);
                        //Console.Read();
                        cur = cur.next;
                    }

                    cur.next = null;
                }
                else
                {

                    for (int i = 0; i < pos - 1; i++)
                    {
                        //Console.WriteLine("position: {0}", pos);
                        //Console.Read();
                        cur = cur.next;
                    }

                    if (pos == 0)
                    {
                        head = cur.next;
                    }

                    else if (cur.next.next == null)
                    {
                        cur.next = null;
                    }
                    else if (cur.next.next != null)
                    {
                        cur.next = cur.next.next;
                        //head = cur.next;
                    }
                }
                this.size--;
            }
            else
            {
                Console.WriteLine("Not a valid value");
                Console.Read();
            }
        }


        public static void PrintNodes<T>(LinkedList<T> list)
        {
            //Node<T> cur = head;
            //int i = 0;
            ////Console.WriteLine("cur: {0}", cur.value);
            //while (cur != null)
            //{
            //    if(cur.next == null)
            //    {
            //        Console.WriteLine("{0}. {1} --> null", i, cur.value.ToString());
            //    }else
            //    {
            //        Console.Write("{0}. {1} -->", i, cur.value);
            //    }
            //    i++;
            //    cur = cur.next;
            //}

            //Console.WriteLine("Size: {0}\n", this.size);
            int i = 0;
            foreach (var item in list)
            {
                Console.WriteLine("{0}.{1}->", item);
                i++;
            }
        }


        public void showError(string x)
        {
            Console.WriteLine(x);
            Console.Read();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void PrintNodes()
        {
            throw new NotImplementedException();
        }
    }


    public interface ILinkedlist
    {
        void PrintNodes();
    }

   
}
