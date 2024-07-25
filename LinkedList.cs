using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsHW4
{
    public class LinkedList
    {
        public Node? First {  get; set; }

        public Boolean isEmpty()
        {
            return First == null;
        }

        public void InsertFirst(int data)
        {
            //create the node
            Node newNode = new Node();
            //put data in the node
            newNode.Data = data;
            // put old node in next
            newNode.Next = First;
            // make the first the new node
            First = newNode;
        }
        public Node DeleteFirst()
        {
            //Assign temp var
            Node temp = First;
            //assign new head
            First = First.Next;
            return temp;
        }
        
        public void DisplayList()
        {
            Console.WriteLine("Iterating through the list....");
            Node current = First;
            while (current != null)
            {
                current.DisplayNode();
                current = current.Next;
            }
        }
        public void InsertLast(int data)
        {
            Node current = First;
            while (current.Next != null)
            {
                current = current.Next;
            }
            Node newNode = new Node();
            newNode.Data = data;
            current.Next = newNode;
        }

    }
}
