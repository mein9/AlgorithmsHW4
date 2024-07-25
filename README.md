# AlgorithmsHW4


**Reflection on Linked Lists and Their Implementation**

From the video and the implementation, I learned a lot about linked lists. A linked list is made up of nodes.
Each node has some data and a reference to the next node in the list. The start of the list is called the head,
and the end of the list points to null. Unlike ArrayLists, which store elements in a continuous block of memory, 
the nodes in a linked list are scattered in memory.

One big difference between linked lists and ArrayLists is how they handle insertion and deletion. 
In a linked list, you can add a new node at the beginning very quickly. You just create a new node, 
set its reference to the current head, and then update the head to this new node. This takes constant time, 
or O(1). Deleting the head node is also fast. You just set the head to the next node and return the old head. This is also O(1).

Implementing a linked list had its challenges. One problem I faced was making sure that the references were correctly 
set when adding or removing nodes. If you’re not careful, you can easily break the list. Another challenge was handling edge cases,
like when the list is empty. Iterating through the list was also tricky. You need to keep track of the current node and use a while loop 
to go through each node until you reach the end of the list.

In future projects, I might use linked lists when I need to add or remove items quickly and don’t need fast access to elements by index.
Linked lists are good for stacks, queues, and other structures where you add and remove items often. They’re also useful when you’re not sure 
how much memory you’ll need since they don’t require a large block of continuous memory.

Overall, the video and the implementation helped me understand how linked lists work and when to use them. 
It showed me the importance of choosing the right data structure for the task at hand.