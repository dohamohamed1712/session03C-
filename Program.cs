using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace session03C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-Write a program that takes a number from the user then print yes if
            //that number can be divided by 3 and 4 otherwise print no.
            int number;
            bool isValid;

            do
            {
                Console.Write("Enter a number: ");
                isValid = int.TryParse(Console.ReadLine(), out number);

                if (!isValid)
                    Console.WriteLine("Invalid input, please enter a valid integer.");
            }
            while (!isValid);

            if (number % 3 == 0 && number % 4 == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");


            //2-Write a program that allows the user to insert an integer then print
            //negative if it is negative number otherwise print positive.

            int num;
            bool isv;

            do
            {
                Console.Write("Enter an integer: ");
                isv = int.TryParse(Console.ReadLine(), out num);

                if (!isv)
                    Console.WriteLine("Invalid input, please enter a valid integer.");
            }
            while (!isv);

            if (num < 0)
                Console.WriteLine("Negative");
            else
                Console.WriteLine("Positive");


            //3-Write a program that takes 3 integers from the user then prints the max   element and the min element.
            int num1, num2, num3;

            Console.Write("Enter first integer: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter third integer: ");
            num3 = int.Parse(Console.ReadLine());

            int max = num1;
            if (num2 > max)
                max = num2;
            if (num3 > max)
                max = num3;

            int min = num1;
            if (num2 < min)
                min = num2;
            if (num3 < min)
                min = num3;

            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);


            //4-Write a program that allows the user to insert an integer number then  check If a number is even or odd.
            int number2;
            bool isoe;

            do
            {
                Console.Write("Enter an integer: ");
                isoe = int.TryParse(Console.ReadLine(), out number2);

                if (!isoe)
                    Console.WriteLine("Invalid input, please enter a valid integer.");
            }
            while (!isoe);

            if (number2 % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");


            //5-Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant)

            Console.Write("Enter a character: ");
            char ch = Convert.ToChar(Console.ReadLine());

            char lowerCh = char.ToLower(ch);

            if (lowerCh == 'a' || lowerCh == 'e' || lowerCh == 'i' || lowerCh == 'o' || lowerCh == 'u')
                Console.WriteLine("vowel");
            else
                Console.WriteLine("Consonant");


            //6-Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            Console.Write("Enter an integer: ");
            int number3 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number3; i++)
            {
                Console.WriteLine(i);
            }

            //7-Write a program that allows the user to insert an integer then  print a multiplication table up to 12.
            Console.Write("Enter an integer: ");
            int number4 = int.Parse(Console.ReadLine());

            for (int j = 1; j <= 12; j++)
            {
                Console.WriteLine(number4 + " x " + j + " = " + (number4 * j));
            }



            //8-Write a program that allows to user to insert number then print all even numbers between 1 to this number
            Console.Write("Enter a number: ");
            int number5 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number5; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }


            //9-Write a program that takes two integers then prints the power
            Console.Write("Enter the base number: ");
            int baseNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the power (exponent): ");
            int exponent = int.Parse(Console.ReadLine());

            double result = Math.Pow(baseNumber, exponent);

            Console.WriteLine(baseNumber + " ^ " + exponent + " = " + result);


            //10-Write a program to enter marks of five subjects and calculate total, average and percentage.

            int[] marks = new int[5];
            int total = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter marks of subject " + (i + 1) + ": ");
                marks[i] = int.Parse(Console.ReadLine());
                total += marks[i];
            }

            double average = total / 5.0;
            double percentage = (total / 500.0) * 100; // assuming each subject is out of 100

            Console.WriteLine("Total = " + total);
            Console.WriteLine("Average = " + average);
            Console.WriteLine("Percentage = " + percentage + "%");


            //11-Write a program to input the month number and print the number of days  in that month.
            Console.Write("Enter month number (1-12): ");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31 days");
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30 days");
                    break;

                case 2:
                    Console.WriteLine("28 or 29 days (depending on leap year)");
                    break;

                default:
                    Console.WriteLine("Invalid month number");
                    break;
            }


            //12-Write a program to create a Simple Calculator.


            char choice;
            do
            {
                Console.Write("Enter first number: ");
                double num_1 = double.Parse(Console.ReadLine());

                Console.Write("Enter an operator (+, -, *, /): ");
                char op = Convert.ToChar(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num_2 = double.Parse(Console.ReadLine());

                double Result = 0;
                bool isValidOperation = true;

                switch (op)
                {
                    case '+':
                        Result = num_1 + num_2;
                        break;

                    case '-':
                        Result = num_1 - num_2;
                        break;

                    case '*':
                        Result = num_1 * num_2;
                        break;

                    case '/':
                        if (num_2 == 0)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            isValidOperation = false;
                        }
                        else
                        {
                            Result = num_1 / num_2;
                        }
                        break;

                    default:
                        Console.WriteLine("Error: Invalid operator.");
                        isValidOperation = false;
                        break;
                }

                if (isValidOperation)
                    Console.WriteLine(num_1 + " " + op + " " + num_2 + " = " + Result);


                Console.Write("Do you want to perform another calculation? (y/n): ");
                choice = Convert.ToChar(Console.ReadLine());
            }
            while (choice == 'y' || choice == 'Y');


            //13-Write a program to allow the user to enter a string and print the  REVERSE of it.

            Console.Write("Enter a string: ");
            string text = Console.ReadLine();

            string reversed = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }

            Console.WriteLine("Reversed string: " + reversed);



            //14-14- Write a program to allow the user to enter int and print the REVERSED  of it.
            Console.Write("Enter an integer: ");
            int number6 = int.Parse(Console.ReadLine());

            int originalNumber = number6;
            int reversed2 = 0;


            bool isNegative = number6 < 0;
            number6 = Math.Abs(number6);

            while (number6 > 0)
            {
                int lastDigit = number6 % 10;
                reversed2 = reversed2 * 10 + lastDigit;
                number6 /= 10;
            }

            if (isNegative)
                reversed2 = -reversed2;

            Console.WriteLine("Original number: " + originalNumber);
            Console.WriteLine("Reversed number: " + reversed2);



            //15- Write a program in C# Sharp to find prime numbers within a range of  numbers.

            Console.Write("Input starting number of range: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Input ending number of range: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("The prime number between " + start + " and " + end + " are :");

            for (int number7 = start; number7 <= end; number7++)
            {
                if (IsPrime(number7))
                {
                    Console.Write(number7 + " ");
                }

            }



            //16-Write a program in C# Sharp to convert a decimal number into binary without using an array

            Console.Write("Enter a decimal number: ");
            int number8 = int.Parse(Console.ReadLine());

            int originalNumber2 = number8;
            long binary = 0;
            int place = 1;

            if (number8 == 0)
            {
                Console.WriteLine("Binary: 0");
            }
            else
            {
                while (number8 > 0)
                {
                    int remainder = number8 % 2;
                    binary += remainder * place;
                    place *= 10;
                    number8 /= 2;
                }

                Console.WriteLine("Decimal: " + originalNumber2);
                Console.WriteLine("Binary: " + binary);
            }


            //17- Create a program that asks the user to input three points (x1, y1),
            //(x2, y2), and(x3, y3), and determines whether these points lie on a single straight line.

            Console.Write("Enter x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("Enter x3: ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("Enter y3: ");
            double y3 = double.Parse(Console.ReadLine());

            Console.Write("Enter x4: ");
            double x4 = double.Parse(Console.ReadLine());
            Console.Write("Enter y4: ");
            double y4 = double.Parse(Console.ReadLine());

            // Collinearity condition:
            // (y2 - y1) * (x3 - x1) == (y3 - y1) * (x2 - x1)
            double leftSide = (y3 - y2) * (x4 - x2);
            double rightSide = (y4 - y2) * (x3 - x2);

            if (leftSide == rightSide)
                Console.WriteLine("The points lie on a single straight line.");
            else
                Console.WriteLine("The points do NOT lie on a single straight line.");

            //18- Within a company, the efficiency of workers is evaluated based on the  duration required to complete a specific task.A worker's efficiency level
            Console.Write("Enter the time taken to complete the task (in hours): ");
            double hours = double.Parse(Console.ReadLine());

            if (hours >= 2 && hours <= 3)
                Console.WriteLine("Highly efficient.");
            else if (hours > 3 && hours <= 4)
                Console.WriteLine("Instructed to increase their speed.");
            else if (hours > 4 && hours <= 5)
                Console.WriteLine("Provided with training to enhance their speed.");
            else if (hours > 5)
                Console.WriteLine("Required to leave the company.");
            else
                Console.WriteLine("Invalid input: time must be 2 hours or more.");


            //Write a program that prints an identity matrix using for loop, in
            //other words takes a value n from the user and shows the identity table of  size n* n.

            Console.Write("Enter the size of the matrix (n): ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write("1\t");
                    else
                        Console.Write("0\t");
                }
                Console.WriteLine();

            }


            //20-Write a program in C# Sharp to find the sum of all elements of the array.

            Console.Write("Enter the number of elements: ");
            int m = int.Parse(Console.ReadLine());

            int[] numbers = new int[m];

            for (int i = 0; i < m; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum2 = 0;
            foreach (int num4 in numbers)
            {
                sum2 += num4;
            }

            Console.WriteLine("Sum of all elements = " + sum2);





            //21-Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            Console.Write("Enter the size of the arrays: ");
            int k = int.Parse(Console.ReadLine());

            int[] array1 = new int[k];
            int[] array2 = new int[k];

            Console.WriteLine("Enter elements of the first array (in ascending order):");
            for (int i = 0; i < k; i++)
            {
                Console.Write("Element " + (i + 1) + ": ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter elements of the second array (in ascending order):");
            for (int i = 0; i < k; i++)
            {
                Console.Write("Element " + (i + 1) + ": ");
                array2[i] = int.Parse(Console.ReadLine());
            }

            int[] merged = new int[k * 2];
            int i1 = 0, i2 = 0, l = 0;

           
            while (i1 < k && i2 < k)
            {
                if (array1[i1] <= array2[i2])
                    merged[l++] = array1[i1++];
                else
                    merged[l++] = array2[i2++];
            }

          
            while (i1 < k)
                merged[l++] = array1[i1++];

            
            while (i2 < k)
                merged[l++] = array2[i2++];

            Console.WriteLine("Merged sorted array:");
            foreach (int num5 in merged)
            {
                Console.Write(num5 + " ");
            }

            //22-Write a program in C# Sharp to count the frequency of each element of   an array.

            Console.Write("Enter the number of elements: ");
            int n1 = int.Parse(Console.ReadLine());

            int[] numbers1 = new int[n1];

            for (int i = 0; i < n1; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                numbers1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Frequency of each element:");

            bool[] visited = new bool[n1];

            for (int i = 0; i < n1; i++)
            {
                if (visited[i])
                    continue;

                int count = 1;
                for (int j = i + 1; j < n1; j++)
                {
                    if (numbers1[i] == numbers1[j])
                    {
                        count++;
                        visited[j] = true;
                    }
                }

                Console.WriteLine(numbers1[i] + " occurs " + count + " time(s)");
            }


            //23-Write a program in C# Sharp to find maximum and minimum element in an array
            Console.Write("Enter the number of elements: ");
            int s = int.Parse(Console.ReadLine());

            int[] numbers3 = new int[s];

            for (int i = 0; i < s; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                numbers3[i] = int.Parse(Console.ReadLine());
            }

            int max2 = numbers3[0];
            int min2 = numbers3[0];

            for (int i = 1; i < s; i++)
            {
                if (numbers3[i] > max2)
                    max2 = numbers3[i];

                if (numbers3[i] < min2)
                    min2 = numbers3[i];
            }

            Console.WriteLine("Maximum element = " + max2);
            Console.WriteLine("Minimum element = " + min2);



            //24-Write a program in C# Sharp to find the second largest element in an  array.
            Console.Write("Enter the number of elements: ");
            int u = int.Parse(Console.ReadLine());

            int[] numbers4= new int[u];

            for (int i = 0; i < u; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                numbers4[i] = int.Parse(Console.ReadLine());
            }

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            for (int i = 0; i < u; i++)
            {
                if (numbers4[i] > largest)
                {
                    secondLargest = largest;
                    largest = numbers3[i];
                }
                else if (numbers3[i] > secondLargest && numbers3[i] != largest)
                {
                    secondLargest = numbers3[i];
                }
            }

            Console.WriteLine("Largest element = " + largest);
            Console.WriteLine("Second largest element = " + secondLargest);


            //25-Consider an Array of Integer values with size N, having values as

            Console.Write("Enter the number of elements: ");
            int w= int.Parse(Console.ReadLine());

            int[] numbers5= new int[w];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < w; i++)
            {
                Console.Write("Element " + (i + 1) + ": ");
                numbers5[i] = int.Parse(Console.ReadLine());
            }

            Dictionary<int, int> firstOccurrence = new Dictionary<int, int>();
            int maxDistance = 0;

            for (int i = 0; i < w; i++)
            {
                if (!firstOccurrence.ContainsKey(numbers5[i]))
                {
                    // Store the first time we see this value
                    firstOccurrence[numbers5[i]] = i;
                }
                else
                {
                    // Calculate distance from the first occurrence to current index
                    int distance = i - firstOccurrence[numbers5[i]] - 1;

                    if (distance > maxDistance)
                        maxDistance = distance;
                }
            }

            Console.WriteLine("The longest distance between two equal cells = " + maxDistance);

            //26-Given a list of space separated words, reverse the order of the words.

            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            string result2 = "";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                result2 += words[i];
                if (i != 0)
                    result2 += " ";
            }

            Console.WriteLine(result2);


            //27-Write a program to create two multidimensional arrays of same size.
            //Accept value from user and store them in first array. Now copy all the
            //elements of first array on second array and print second array.

            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] firstArray = new int[rows, cols];
            int[,] secondArray = new int[rows, cols];

            Console.WriteLine("Enter elements of the first array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("Element [" + i + "," + j + "]: ");
                    firstArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Copy all elements from firstArray to secondArray
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    secondArray[i, j] = firstArray[i, j];
                }
            }

            Console.WriteLine("Second array (copied):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(secondArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //28-Write a Program to Print One Dimensional Array in Reverse Order
            Console.Write("Enter the number of elements: ");
            int q = int.Parse(Console.ReadLine());

            int[] numbers6 = new int[q];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < q; i++)
            {
                Console.Write("Element " + (i + 1) + ": ");
                numbers6[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array in reverse order:");
            for (int i = q - 1; i >= 0; i--)
            {
                Console.Write(numbers6[i] + " ");
            }
        }
        private static bool IsPrime(int number7)
        {
            if (number7 < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number7); i++)
            {
                if (number7 % i == 0)
                    return false;
            }

            return true;

        }





    }
}


