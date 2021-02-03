# Trees Challenge 15
Initial implementation of the Binary and Binary Search Tree classes, and their own Node class with appropriate right and left pointer properties.

## Challenge
Implement a class library called trees, that contain a node, binary and binary search tree classes. In the Binary Tree class, write 3 traversal methods, one for Pre-Order, In-Order and Post-Order, which return an array of integers in the correct order. In the BInary Search Tree class, write methods that add a new node to the appropriate place in the tree and one that takes in a value and return whether or not that value exists in the tree.


## Approach & Efficiency
The time efficiency for tranversing out trees is going to the O(n), because we will always be traversing the whole tree. Space will be O(n) because we are returning a new array or list. For the Contains method the efficiency for time is O(logn)
because we cut our search in half everytime it calls itself. Space will be O(1) because we are just returning true or false.
## API
Public Methods: Add(), Contains(), PreOrder(), InOrder(), PostOrder()


# Trees Challenge 17
Write a mehtod that traverses a tree using breadth-first traversal.
## Challenge
Write a breadth first traversal method which takes a Binary Tree as its unique input. Without utilizing any of the built-in methods available to your language, traverse the input tree using a Breadth-first approach, and return a list of the values in the tree in the order they were encountered.

## Approach & Efficiency
!(WhiteBoard)[./challenge17.png]
## API
Public Methods: BreadthFirstTraversal()
