# Code Challenge 10
Create Stack and Queue Classes, both containing methods that allow one to add nodes, remove nodes, check node's values, and varify if each respective collection contains anything. Also includes unit tests

## Challenge
- Create a Node class that has properties for the value stored in the Node, and a pointer to the next node.
- Create a Stack class that has a top property. It creates an empty Stack when instantiated.
- This object should be aware of a default empty value assigned to top when the stack is created.
- Define a method called push which takes any value as an argument and adds a new node with that value to the top of the stack with an O(1) Time performance.
- Define a method called pop that does not take any argument, removes the node from the top of the stack, and returns the node’s value.
- Should raise exception when called on empty stack
- Define a method called peek that does not take an argument and returns the value of the node located on top of the stack, without removing it from the stack.
- Should raise exception when called on empty stack
- Define a method called isEmpty that takes no argument, and returns a boolean indicating whether or not the stack is empty.
- Create a Queue class that has a front property. It creates an empty Queue when instantiated.
- This object should be aware of a default empty value assigned to front when the queue is created.
- Define a method called enqueue which takes any value as an argument and adds a new node with that value to the back of the queue with an O(1) Time performance.
- Define a method called dequeue that does not take any argument, removes the node from the front of the queue, and returns the node’s value.
- Should raise exception when called on empty queue
- Define a method called peek that does not take an argument and returns the value of the node located in the front of the queue, without removing it from the queue.
- Should raise exception when called on empty queue
- Define a method called isEmpty that takes no argument, and returns a boolean indicating whether or not the queue is empty.
- Be sure to follow your languages best practices for naming conventions.

## Approach & Efficiency
- Create a stack class with a top property. Assign an empty value to top when the stack is created.
- Create a method called push which will take any values to the top with an O(1) time performance.
- Create a method called pop that does not take any argument, removes node from the top and returns value
- Cretae a method called peek that does NOT take an argument and returns the value of the node located on top.
- Create a method isEmpty that takes no arguments, returns bool.
- Create a queue class with property of front.
- Create a method called enqueue that takes any value as argument, adds a new node w/ value to the back of the queue w/ O(1) performance.
- Create a method called dequeue that does NOT take any argument, removes node from the front of the queue and returns node value.
- Create a method called peek that does NOT take any arguments and returns value of node located in front of the queue, exception handle should be raised if empty
- Create a method isEmpty that takes no arguments and returns bool, indicating empty or not empty queue## API
Public Methods:
- Pop(), Push(), IsEmpty(), Peek(), Enqueue(), Dequeue()
Public Classes:
- Queue, Stack
