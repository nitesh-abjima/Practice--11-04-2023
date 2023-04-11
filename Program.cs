using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        //HashSet

        HashSet<int> odd = new HashSet<int>();

        // Inserting elements in HashSet
        for (int i = 0; i < 5; i++)
        {
            odd.Add(2 * i + 1);
        }

        // Displaying the elements in the HashSet
        foreach (int i in odd)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Elements contains in HashSet-- " + odd.Count);

        // HashSet of strings

        HashSet<string> mySet = new HashSet<string>();

        // Inserting elements in HashSet
        mySet.Add("DS");
        mySet.Add("C++");
        mySet.Add("Java");
        mySet.Add("JavaScript");

        // Check if a HashSet contains
        // the specified element

        if (mySet.Contains("Java"))
            Console.WriteLine("Required Element is present");
        else
            Console.WriteLine("Required Element is not present");

        //Multidimentional Array

        int[,] numbers = { { 2, 3 }, { 4, 5 } };

        // access first element from the first row
        Console.WriteLine("Element at index [0, 0] : " + numbers[0, 0]);

        // access first element from second row
        Console.WriteLine("Element at index [1, 0] : " + numbers[1, 0]);

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            Console.Write("Row " + i + ": ");

            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write(numbers[i, j] + " ");

            }
            Console.WriteLine();

        }

        // Jagged Array

        int[][] jagged_arr = new int[4][];

        // Initialize the elements
        jagged_arr[0] = new int[] { 1, 2, 3, 4 };
        jagged_arr[1] = new int[] { 11, 34, 67 };
        jagged_arr[2] = new int[] { 89, 23 };
        jagged_arr[3] = new int[] { 0, 45, 78, 53, 99 };

        // Display the array elements:
        for (int n = 0; n < jagged_arr.Length; n++)
        {

            // Print the row number
            Console.Write("Row({0}): ", n);

            for (int k = 0; k < jagged_arr[n].Length; k++)
            {

                // Print the elements in the row
                Console.Write("{0} ", jagged_arr[n][k]);
            }
            Console.WriteLine();
        }

        // Declaration and Initialization of 
        // Jagged array with 4 2-D arrays
        int[][,] jagged_arr1 = new int[4][,] {new int[, ] {{1, 3}, {5, 7}},
                                    new int[, ] {{0, 2}, {4, 6}, {8, 10}},
                                    new int[, ] {{7, 8}, {3, 1}, {0, 6}},
                                    new int[, ] {{11, 22}, {99, 88}, {0, 9}}};

        // Display the array elements:
        // Length method returns the number of
        // arrays contained in the jagged array
        for (int i = 0; i < jagged_arr1.Length; i++)
        {

            int x = 0;

            // GetLength method takes integer x which 
            // specifies the dimension of the array
            for (int j = 0; j < jagged_arr1[i].GetLength(x); j++)
            {

                // Rank is used to determine the total 
                // dimensions of an array 
                for (int k = 0; k < jagged_arr1[j].Rank; k++)
                    Console.WriteLine("Jagged_Array[" + i + "][" + j + ", " + k + "]: "
                                                + jagged_arr1[i][j, k] + " ");
                Console.WriteLine();
            }
            x++;
            Console.WriteLine();
        }

        // Stack-- Non generic

        Stack my_stack = new Stack();

        // Adding elements in the Stack
        // Using Push method
        my_stack.Push("Nitesh");
        my_stack.Push("Roger");
        my_stack.Push('G');
        my_stack.Push(null);
        my_stack.Push(1234);
        my_stack.Push(490.98);

        // Accessing the elements

        foreach (var elem in my_stack)
        {
            Console.WriteLine(elem);
        }
        Console.WriteLine();

        // Checking if the element is
        // present in the Stack or not

        if (my_stack.Contains("Roger") == true)
        {
            Console.WriteLine("Element is found...!!");
        }

        else
        {
            Console.WriteLine("Element is not found...!!");
        }

        Console.WriteLine();
        Console.WriteLine("Total elements present in" +
                     " my_stack: {0}", my_stack.Count);

        Console.WriteLine("Topmost element of my_stack"
                          + " is: {0}", my_stack.Pop());

        Console.WriteLine("Total elements present in" +
                    " my_stack: {0}", my_stack.Count);

        Console.WriteLine("Topmost element of my_stack " +
                              "is: {0}", my_stack.Peek());

        Console.WriteLine("Total elements present " +
                 "in my_stack: {0}", my_stack.Count);

        // Stack-- Generic 

        Stack<int> number = new Stack<int>();

        // add two elements to the stack
        number.Push(1);
        number.Push(5);

        // print elements inside the numbers Stack 
        foreach (int item in number)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        //Queue

        Queue my_queue = new Queue();

        // Adding elements in Queue
        my_queue.Enqueue("ABC");
        my_queue.Enqueue(1);
        my_queue.Enqueue(100);
        my_queue.Enqueue(null);
        my_queue.Enqueue(2.4);
        my_queue.Enqueue("ABC123");

        // Accessing the elements
       
        foreach (var ele in my_queue)
        {
            Console.WriteLine(ele);
        }
        Console.WriteLine();

        Console.WriteLine("Total elements present in my_queue: {0}",
                                                    my_queue.Count);
        my_queue.Dequeue();

        // After Dequeue method
        Console.WriteLine("Total elements present in my_queue: {0}",
                                                    my_queue.Count);

        Console.WriteLine();

        // Checking if the element is
        // present in the Queue or not
        if (my_queue.Contains("ABC") == true)
        {
            Console.WriteLine("Element available...!!");
        }
        else
        {
            Console.WriteLine("Element not available...!!");
        }
    }
}
