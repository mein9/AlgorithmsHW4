﻿namespace AlgorithmsHW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.InsertFirst(1);
            linkedList.InsertFirst(2);
            linkedList.InsertFirst(3);
            linkedList.InsertFirst(4);

            linkedList.DeleteFirst();
            linkedList.DeleteFirst();

            linkedList.InsertLast(546);
            linkedList.InsertLast(3434);

            linkedList.DisplayList();

            
        }
    }
}
