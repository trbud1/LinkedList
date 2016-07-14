using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTest
{
    class Game
    {

        LinkedList myList = new LinkedList();
        public  void gameMenu()
        {
            string selection;
            initLinkedList();
            
            do
            {
                //Clear previous items.
                Console.Clear();

                //Display contents.
                myList.PrintNodes();
                PrintMenu();
                
                //Read users input.
                selection = Console.ReadLine();

                switch (selection)
                {
                    //Add Start
                    case "1":
                        myList.addNodeStart();
                        break;
                    //Add End
                    case "2":
                        myList.addNodeEnd(GetName());
                        break;
                    //Delete start
                    case "3":
                        DeleteAtIndex(0);
                        //myList.removeNode(0);
                        break;
                    //Delete End
                    case "4":
                        DeleteAtIndex(myList.size - 1);
                        //myList.removeNode(myList.size - 1);
                        break;
                    //Delete at index
                    case "5":
                        DeleteAtIndex(-1);
                        
                        break;
                    case "6":
                        InsertAtLocation();
                        
                        break;

                    default:
                        break;

                }

            } while (!selection.Equals(99));
        }

        public void DeleteAtIndex(int i)
        {

            if (i == -1)
            {
                Console.WriteLine("Enter index to delete: ");
                i = int.Parse(Console.ReadLine());
                myList.removeNode(i);
            }
            else
            {
                myList.removeNode(i);
            }
            
        }

        public void InsertAtLocation()
        {
            Console.WriteLine("Enter node location: ");
            int pos = int.Parse(Console.ReadLine());
            Node newNode = new Node(GetName());

            myList.addNodeAt(pos, newNode);
        }

        public string GetName()
        {
            Console.WriteLine("Enter node name: ");
            return Console.ReadLine();
        }

        public void PrintMenu()
        {
            Console.WriteLine("1. Insert at start");
            Console.WriteLine("2. Insert at end");
            Console.WriteLine("3. Delete at start");
            Console.WriteLine("4. Delete at end");
            Console.WriteLine("5. Delete at index");
            Console.WriteLine("6. Insert at index");
            Console.Write("Option (99 to exit): ");
        }

        public void initLinkedList()
        {
            string[] items = new string[] { "Sixth", "Fifth", "Fourth", "Third", "Second", "First" };

            foreach (string i in items)
            {
                myList.add(i);
            }
        }

    }
}
