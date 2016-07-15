using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTest
{
    public class LinkedListEnumerator<T> : IEnumerator<T>
    {
        private LinkedList<T> _LinkedList;
        private Node<T> current;

        public LinkedListEnumerator(LinkedList<T> mylinkedlist)
        {
            _LinkedList = mylinkedlist;
            current = _LinkedList.head;

        }


        public T Current
        {
            get
            {
                return current.value;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (current.next != null)
            {
                current = current.next;
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Reset()
        {
            current = _LinkedList.head;
        }
    }
}
