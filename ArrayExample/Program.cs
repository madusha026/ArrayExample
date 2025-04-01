using System;

class Program
{
    static void Main(string[] args)
    {
        //Task 1: Create and Print a Double Array
        double[] myArray = new double[10];
        myArray[0] = 1.0;
        myArray[1] = 1.1;
        myArray[2] = 1.2;
        myArray[3] = 1.3;
        myArray[4] = 1.4;
        myArray[5] = 1.5;
        myArray[6] = 1.6;
        myArray[7] = 1.7;
        myArray[8] = 1.8;
        myArray[9] = 1.9;

        // Print all elements
        Console.WriteLine("Task 1: Array Elements:");
        Console.WriteLine();
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine($"Element {i}: {myArray[i]}");
        }
        Console.WriteLine();

        // Task 2: Use a Loop to Assign and Print Values to an Integer Array
        int[] studentArray = new int[10];
        for (int i = 0; i < studentArray.Length; i++)
        {
            studentArray[i] = i;
        }

        
        Console.WriteLine("Task 2: Student Array Elements:");
        Console.WriteLine();
        // Print all elements
        for (int i = 0; i < studentArray.Length; i++)
        {
            Console.WriteLine($"Student {i}: {studentArray[i]}");
        }
        Console.WriteLine();

        // Task 3: Calculate the Total and Average of an Integer Array
        Console.WriteLine("Task 3: Calculate Total and Average of Student Grades:");
        Console.WriteLine();

        // Create an integer array of student grades
        
        int[] studentGrades = {87, 68, 94, 100, 83, 78, 85, 91, 76, 87};
        int total = 0;
        for (int i = 0; i < studentGrades.Length; i++)
        {
            total += studentGrades[i];
        }
        // and calculate the total and average
        double average = (double)total / studentGrades.Length;

        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine();

        //Task 4: User Input for Storing Names in an Array
        Console.WriteLine("Task 4: Enter Student Names:");
        Console.WriteLine();
        // Create a string array to store student names
        // and read input from the user
        string[] studentNames = new string[6];
        for (int i = 0; i < studentNames.Length; i++)
        {
            Console.WriteLine($"Enter name for student {i + 1}: ");
            studentNames[i] = Console.ReadLine();
        }

        Console.WriteLine("\nEntered Student Names:");
        for (int i = 0; i < studentNames.Length; i++)
        {
            Console.WriteLine(studentNames[i]);
        }
        Console.WriteLine();

        // Task 5: Find the Largest and Smallest Values in an Array
        Console.WriteLine("Task 5: Find Largest and Smallest Values in an Array:");
        Console.WriteLine();
        // Create a one-dimensional double array of length 10
        double[] numbers = new double[10];
        int currentSize = 0;  // Initialize currentSize to 0

        // Read input for the array
        Console.WriteLine("Enter values for the array:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Enter value for element {i}: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
            currentSize++;  // Increment currentSize for each value entered
        }

        // Create currentLargest and currentSmallest variables
        double currentLargest = numbers[0];
        double currentSmallest = numbers[0];

        // Print the content of the array
        Console.WriteLine("\nArray Contents:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Element {i}: {numbers[i]}");
        }

        // Find the largest and smallest values
        for (int i = 1; i < numbers.Length; i++)  // Start from index 1 since currentLargest and currentSmallest are initialized with numbers[0]
        {
            if (numbers[i] > currentLargest)
                currentLargest = numbers[i];

            if (numbers[i] < currentSmallest)
                currentSmallest = numbers[i];
        }

        // Print the largest and smallest values
        Console.WriteLine($"\nLargest Value: {currentLargest}");
        Console.WriteLine($"Smallest Value: {currentSmallest}");
        Console.WriteLine();

        // Task 6: Multi-Dimensional Array and Nested Loops
        Console.WriteLine("Task 6: Multi-Dimensional Array:");
        Console.WriteLine();
        // Create a 2D array and print its contents using nested loops
        // Create a 2D array of integers
        int[,] my2DArray = { {1, 2, 3, 4}, {1, 1, 1, 1}, {2, 2, 2, 2} };

        Console.WriteLine("2D Array:");
        for (int i = 0; i < my2DArray.GetLength(0); i++) // Loop through rows
        {
            for (int j = 0; j < my2DArray.GetLength(1); j++) // Loop through columns
            {
                Console.Write(my2DArray[i, j] + " ");
            }
            Console.WriteLine(); // Move to the next row
        }
        Console.WriteLine();

        // Task 7: List Implementation and Random Numbers
        Console.WriteLine("Task 7: List Implementation and Random Numbers:");
        Console.WriteLine();
        // Create a list of students with random number of students (1-12)
        // and print the list
        Random random = new Random();
        List<string> studentList = new List<string>();

        int numStudents = random.Next(1, 13); // Random number between 1 and 12
        for (int i = 0; i < numStudents; i++)
        {
            studentList.Add("Student " + (i + 1));
        }

        Console.WriteLine($"Number of students: {numStudents}");
        foreach (var student in studentList)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine();

        // Task 8: Palindrome Method
        Console.WriteLine("Task 8: Palindrome Method:");
        Console.WriteLine();
        // Create an integer array and check if it is a palindrome
        int[] palindromeArray = {1, 2, 2, 1};
        Console.WriteLine($"Is palindrome: {Palindrome(palindromeArray)}");

        int[] nonPalindromeArray = {1, 2, 3};
        Console.WriteLine($"Is palindrome: {Palindrome(nonPalindromeArray)}");
        Console.WriteLine();

        // Task 9: Merge Sorted Lists
        Console.WriteLine("Task 9: Merge Sorted Lists:");
        Console.WriteLine();
        // Create two sorted lists
        List<int> listA = new List<int> {1, 2, 2, 5};
        List<int> listB = new List<int> {1, 3, 4, 5, 7};

        List<int> mergedList = Merge(listA, listB);
        if (mergedList != null)
        {
            Console.WriteLine("Merged List: ");
            foreach (var item in mergedList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Lists are not sorted.");
        }

        Console.WriteLine();


        // Task 10: Array Conversion (2D to 1D with odd values)
        Console.WriteLine("Task 10: Array Conversion (2D to 1D with odd values):");
        Console.WriteLine();
        // Create a 2D array and convert it to a 1D array with odd values
        int[,] myArray2 = {
            { 0, 2, 4, 0, 9, 5 },
            { 7, 1, 3, 3, 2, 1 },
            { 1, 3, 9, 8, 5, 6 },
            { 4, 6, 7, 9, 1, 0 }
        };

        int[] result = ArrayConversion(myArray2);
        Console.WriteLine("Odd values in the array: ");
        foreach (var item in result)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();


    }

    // Palindrome Method
    static bool Palindrome(int[] array)
    {
        if (array.Length < 1) return false;

        for (int i = 0; i < array.Length / 2; i++)
        {
            if (array[i] != array[array.Length - 1 - i])
                return false;
        }
        return true;
    }

    // Merge Method
    static List<int> Merge(List<int> list_a, List<int> list_b)
    {
        if (!IsSorted(list_a) || !IsSorted(list_b))
            return null;

        List<int> mergedList = new List<int>(list_a);
        mergedList.AddRange(list_b);
        mergedList.Sort();
        return mergedList;
    }

    static bool IsSorted(List<int> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i] > list[i + 1])
                return false;
        }
        return true;
    }

    // ArrayConversion Method
    static int[] ArrayConversion(int[,] array)
    {
        List<int> oddValues = new List<int>();

        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                if (array[row, col] % 2 != 0)
                    oddValues.Add(array[row, col]);
            }
        }

        return oddValues.ToArray();
    }

}
