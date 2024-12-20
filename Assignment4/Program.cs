using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Collections.Generic;
using System.Numerics;
using System.Diagnostics.Metrics;
using System.Linq;
using System;
using System.Text;
using System.Drawing;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Write a program that allows the user to insert an integer then print all numbers between 1 to that number

            //Console.Write("Enter A Number :");
            //int number=int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //Console.WriteLine(i);
            //}


            #endregion

            #region Q02
            // Write a program that allows the user to insert an integer then print a multiplication table up to 12.


            //Console.Write("Enter an integer: ");
            //int num =int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //Console.WriteLine(num*i);
            //}



            #endregion

            #region Q03
            //  Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.Write("Enter an integer: ");
            //int num =int.Parse(Console.ReadLine());


            //for (int i = 1; i <= num; i++)
            //{

            //if (i % 2 == 0)
            //Console.WriteLine(i);

            //}




            #endregion

            #region Q04

            // Write a program that takes two integers then prints the power.

            //Console.Write("Enter an num 1: ");
            //int num1 =int.Parse(Console.ReadLine());

            //Console.Write("Enter an num 2: ");
            //int num2 = int.Parse(Console.ReadLine());


            //double result;
            //result=Math.Pow(num1,num2);
            //Console.WriteLine(result);

            #endregion

            #region Q05
            // Write a program to allow the user to enter a string and print the REVERSE of it




            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //for (int i = input.Length - 1; i >= 0; i--)

            //{
            //Console.Write(input[i]);
            //}



            // or



            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //string reverse = new string(input.Reverse().ToArray());
            //Console.WriteLine(reverse);
            #endregion

            #region Q06

            // Write a program in C# Sharp to find prime numbers within a range of numbers.



            //Console.Write("Enter Start Number: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("Enter End Number: ");
            //int end = int.Parse(Console.ReadLine());

            //int count = 0;

            //for (int i = start; i < end; i++)

            //{
            //count = 0;
            //for (int j= 2; j < i;j++)
            //{
            //if(i%j== 0)
            //{
            //count++;
            //break;
            //}

            //}
            //if (count == 0 & i !=1)
            //Console.WriteLine(i);
            //}















            //for (int i = start; i < end; i++)

            //{

            //if (isprime(i))
            //{
            //Console.WriteLine(i);
            //}
            //}








            #endregion

            #region Q07
            //Write a program in C# Sharp to convert a decimal number into binary without using an array.


            //Console.Write("Enter a number: ");
            //int input = int.Parse(Console.ReadLine());


            //for (int i = 0; input > 0; i++)
            //{


            //}

            #endregion

            #region Q08

            //Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.


            //Console.Write("Enter a identity matrix number: ");
            //int n = int.Parse(Console.ReadLine());

            //int[,] matrix=new int[n,n];

            //for (int i = 0; i < n; i++ )

            //{
            //for (int j = 0; j < n; j++)
            //{



            //}
            //}




            #endregion


            #region Q09

            //Write C# program that Extract a substring from a given string

            //Console.Write("Enter a string : ");
            //string MAINSTRING =Console.ReadLine();


            //Console.Write("Enter the start position: ");
            //int start = int.Parse(Console.ReadLine());



            //Console.Write("Enter the length: ");
            //int length = int.Parse(Console.ReadLine());


            //StringBuilder substring = new StringBuilder(MAINSTRING.Substring(start, length));

            //Console.WriteLine(substring.ToString());


            #endregion

            #region Q10


            //Console.Write("Enter the first string: ");
            //string string1 = Console.ReadLine();

            //Console.Write("Enter the second string: ");
            //string string2 = Console.ReadLine();


            //StringBuilder substring = new StringBuilder(string1+string2);


            //Console.WriteLine(substring);



            #endregion


            #region Q11

            //same Q08

            #endregion

            #region Q12

            //- Write a program in C# Sharp to find the sum of all elements of the array.

            //int[] numbers = new int[3];
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)

            //{
            //Console.WriteLine($"Enter 3 Numbers {i+1} :");


            //numbers[i] = int.Parse(Console.ReadLine());
            //sum += numbers[i];
            //}

            //Console.WriteLine($"sum of numbers :{sum}");


            #endregion


            #region Q13


            //int[] array1 = { 1, 3, 5, 7 };
            //int[] array2 = { 2, 4, 6, 8 };

            //int[] mergeArray = new int[array1.Length /2 + array2.Length /2];
            //Console.WriteLine(mergeArray);

            #endregion


            #region Q14

            //Write a program in C# Sharp to count the frequency of each element of an array

            //int[] numbers = new int[] {1,2,2,2,3,3,3,4,4,4,4,5,5,5, };
            //int Count ;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //if (Count[i])
            //{ 

            //}
            //}

            #endregion

            #region Q15

            //int[] numbers = new int[5];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //Console.Write($"Enter 5 numbers {i + 1}: ");
            //numbers[i] = int.Parse(Console.ReadLine());
            //}

            //int max = numbers[0];
            //int min = numbers[0];

            //foreach (int num in numbers)
            //{
            //if (num > max)
            //{
            //max = num;
            //}

            //else if (num < min)
            //{
            //min = num;
            //}
            //}
            //Console.WriteLine($"max num :{max}");
            //Console.WriteLine($"min num :{min}");
            #endregion

            #region Q16

            //Write a program in C# Sharp to find the second largest element in an array





            //int[] numbers = new int[5];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //Console.Write($"Enter 5 numbers {i + 1}: ");
            //numbers[i] = int.Parse(Console.ReadLine());
            //}



            //int max = numbers[0];
            //int secondMax = max-1;

            //foreach (int num in numbers)
            //{
            //if (num > max)
            //{
            //secondMax = max;  
            //max = num;  
            //}
            //else if (num > secondMax && num != max)
            //{
            //secondMax = num;  
            //}
            //}

            //Console.WriteLine($"second max : {secondMax}");

            #endregion

            #region Q17
            //-. Consider an Array of Integer values with size N, having values as in this Example



            //int[] numbers = { 7, 0, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };

            //int distance = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //for (int j = i + 1; j < numbers.Length; j++)
            //{

            //distance += numbers[i];



            //}
            //}
            #endregion



            #region Q18


            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter the number of columns: ");
            //int columns = int.Parse(Console.ReadLine());

            //int[,] firstArray = new int[rows, columns];
            //int[,] secondArray = new int[rows, columns];


            #endregion



            #region Q19

            //Console.WriteLine("Enter the size :");
           //int size=int.Parse(Console.ReadLine());

            //int[] array=new int[size+1];

            //for(int i =size-1;i>0;i--)
            //{

            //array[i]=int.Parse(Console.ReadLine());
            //}
            //for (int i = size - 1; i >= 0; i--)
            //{
                //array.Reverse();

               //Console.Write(array[i]);
            //}


            #endregion
        }


    }
}

