using System;
using System.Collections.Generic;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            do
            {
                value = Menu();
                switch (value)
                {
                    case 1:
                        Console.WriteLine($"choice: {value} \n");
                        EvenNumbers(0, 30);
                        break;

                    case 2:
                        Console.WriteLine($"choice: {value} ");
                        IsItZero();

                        break;

                    case 3:
                        Console.WriteLine($"choice: {value} ");
                        smallBig();
                        break;

                    case 4:
                        Console.WriteLine($"choice: {value} ");
                        subString();
                        break;

                    case 5:
                        Console.WriteLine($"choice: {value} ");
                        printMedianMean(10);
                        break;

                    case 6:
                        Console.WriteLine($"choice: {value} ");
                        //@TODO
                        break;

                    case 7:
                        Console.WriteLine($"choice: {value} ");
                        //@TODO
                        break;

                    case 8:
                        Console.WriteLine($"choice: {value} ");
                        //@TODO
                        break;

                    case 9:
                        Console.WriteLine($"choice: {value} ");
                        //@TODO
                        break;

                    case 10:
                        Console.WriteLine($"choice: {value} quitting...\n");
                        break;

                    default:
                        Console.WriteLine("Wrong number, try again");
                        //@TODO
                        break;
                }
            } while (value != 10);

            Console.WriteLine("-------------END OF PROGRAM-------------");

        }

        static int Menu()
        {
            Console.WriteLine("***************************************************************************************************************\n");

            Console.WriteLine("1. Print even integers between 0 and 30\n");

            Console.WriteLine("2. Read input integer and write if its positive, negative or equal to zero\n");

            Console.WriteLine("3. Read an integer n and then read n inputs from user. Then the smalest and biggest value should be written\n");

            Console.WriteLine("4. Read input string and write how many times the substring \"AB\" occurs\n");

            Console.WriteLine("5. Use an array for a 10 integer input and then print the median and a mean value\n");

            Console.WriteLine("6. Read two integer input and print the sum\n");

            Console.WriteLine("7. Write a function isAlpha that read a char and writes if the char is in the alphabet or not \n");

            Console.WriteLine("8. Dont let the program crash from an invalid input (done)?\n");

            Console.WriteLine("9. Randomly selects a new lotto row with seven columns between 0 and 37\n");

            Console.WriteLine("10. Quit\n");

            Console.Write("Your choice: ");

            //some Exception code down....
            int val;
            try
            {
                val = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                val = -1;
            }

            Console.WriteLine("###############################################################################################################");
            return val;
        }

        static void EvenNumbers(int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine("");
        }
        static void IsItZero()
        {
            Console.Write("Write a number: ");
            int number;
            try
            {
                number = int.Parse(Console.ReadLine());
                if (number < 0)
                    Console.WriteLine($" {number} is negative");
                else if (number > 0)
                    Console.WriteLine($"{number} is positive");
                else
                    Console.WriteLine($"{number} is zero");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void smallBig()
        {
            int size;
            Console.Write("size: ");
            try
            {
                size = int.Parse(Console.ReadLine());

                var numbers = new List<int>{};

                for (int i = 0; i < size; i++)
                {
                    bool isNotNumber = true;
                    do
                    {
                        int n;
                        try
                        {
                            Console.Write($"number {i}: ");
                            n = int.Parse(Console.ReadLine());
                            numbers.Add(n);
                            isNotNumber = false;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }


                    } while (isNotNumber);
                }
                numbers.Sort();
                Console.WriteLine($"smallest: {numbers[0]}, biggest: {numbers[numbers.Count - 1]}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }

        static void subString()
        {
            Console.Write("Write some string that may contain the substring \"AB\": ");
            string text = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'A')
                {
                    i++;
                    if (i < text.Length && text[i] == 'B')
                    {
                        sum++;
                    }
                }
            }

            Console.WriteLine($"AB occurs {sum} times");
        }

        static void printMedianMean( int size)
        {
            var numbers = new List<int> { };
            int sum = 0;
            for (int i=0; i<size; i++) 
            {
                bool goodInput;
                do
                {
                    Console.Write($"skriv in tal {i + 1}/{size} : ");
                    try
                    {
                        numbers.Add(int.Parse(Console.ReadLine()));
                        sum += numbers[i];
                        goodInput = true;
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        goodInput = false;
                    }
                } while (!goodInput);
            }
            numbers.Sort();
            Console.WriteLine($"medianen = {numbers[size/2 -1]}");
            Console.WriteLine($"medelvärde = {sum/size}");
        }
    }
}
