﻿using System.ComponentModel.DataAnnotations;

namespace Asssignment5
{
    internal class Program
    {
        //data
        //functions
        //Types of functions 
        //1.class member function [static function]
        //2.oblect member function [non static function]

        //(*-*)
        public static void PrintShape(int Count=2,string Patern="*/")
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(Patern);
            }
        }
        public static void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;

        }
        public static void Swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;

        }
        public static int SumOfArray(params int[] array)
        {
            int sum = 0;
            //array[0] = 100;
            array = new int []{4,5,6 };
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public static int SumOfArray(ref int[] array)
        {
            int sum = 0;
            array = new int[] { 4, 5, 6 };
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static void SumMul(int x, int y , out int sum, out int mul)
        {
             sum = x + y;
             mul = x * y;
            //return sum;
            //return Mul; // invalid
        }
        public static void SumAndSub(int no1, int no2,out int sum,out int sub)
        {
            sum=no1 + no2;
            sub = no1 - no2;
        }
        public static bool IsPrime(int Number)
        {
            for (int i = 2; i < Number; i++)
            {
                if (Number % i == 0)
                {
                    return false;
                }
               
            }
            return true;
            
        }
        public static void MaxAndMinArray(ref int[] array,out int max,out int min)
        {
            int maxi = 0;
            int Mini = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxi)
                {
                    maxi=array[i];
                }
                if (array[i] < Mini)
                {
                    Mini=array[i];
                }
            }
            max = maxi;
            min = Mini;
          
        }
        public static long Factorial(int Number)
        {
            long result = 1;
            
            for (int i = 1; i <= Number; i++)
            {
                result *= i;
            }
            return result;
        }
        public static int SumDigits(int Number)
        {
            int Sum = 0;
            while (Number > 0)
            {
                Sum += Number % 10;
                Number /= 10;
            }
            return Sum;
        }
        static void Main(string[] args)
        {
            #region Demo
            #region Casting[Boking and Unbokinng]
            //Reference type casting => Convert from reference type to reference type
            //Boking  casting => Convert from value type to reference type
            //Unboking  casting => Convert from reference  type to value type
            //object obj = new object();
            //obj = "Ali"; //refernce type casting
            //obj = 2;//boking casting[casting from value type (int) to reference type (oblect)]
            #region Bohing[Safe casting]
            //int x = 10;
            //object obj = new object();
            //obj = x;
            //Console.WriteLine(x);
            //PARENT = CHILD
            //Dog is animal

            #endregion
            #region Unboxing[Unsafe code]
            //object obj = new object();
            //obj = 10;
            //int x = (int)obj;
            //Console.WriteLine(x);
            //child = parent
            //animal is dog
            #endregion
            #endregion
            #region Nullabel data type
            #region Value type
            //int x = null;// int numbers only

            //int? x = null;// int numbers and null

            //Nullable<int> numbers;
            //int x = 10;
            //int? y = x;
            //int? y = 10;
            //int x =(int) y;
            //Console.WriteLine(x);
            //int? x = 10;
            //int y;
            //if (x !=null)
            //{
            //    y=(int)x;//explicit casting
            //}
            //else
            //{
            //    y = 0;
            //}
            //if (x.HasValue)
            //{
            //    y = x.Value;//not casting
            //}
            //else
            //{
            //    y = 0;
            //}
            //y= x.HasValue? x.Value :  0;
            //Console.WriteLine(y); 
            #endregion
            #region Reference type
            //string? Name = null;//compiler enhancement

            //Console.WriteLine(Name);
            #endregion
            #endregion
            #region Null propegation operaator
            //int[] Numbers = { 1, 2, 3 };
            //for (int i = 0;Numbers != null(not used) && i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //} 
            //for (int i = 0; i < Numbers?.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            //if (Numbers != null)
            //{
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //Console.WriteLine(Numbers[i]);
            //}
            //}

            //i < Numbers?.Length
            // Numbers=> object [length]
            // Numbers=> null [null]

            //int? Length = Numbers?.Length;
            //int Length = Numbers?.Length ?? 0;
            //Console.WriteLine(Length);


            #endregion
            #region Functions
            //PrintShape(5,"/*/*");//Passing by order
            //PrintShape(Count: 6, Patern: "*/*");// passing by name
            //PrintShape();

            //Hello moustafa 
            //welcome to    route
            //Console.WriteLine("Hello Moustafa \nWelcome to \troute");
            //PrintShape(3,@"\*/");
            //PrintShape(3,"\\*//");
            //C:\Users\bassi\Desktop\learn CS\Asssignment5\Asssignment5.sln
            //string path = @"C:\\Users\\bassi\\Desktop\\learn CS\\Asssignment5\\Asssignment5.sln";
            //Console.WriteLine(path);
            #endregion
            #region Value type parameters
            #region By value
            //int A = 10;
            //int B = 20;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Swap(A, B);
            //Console.WriteLine(A);
            //Console.WriteLine(B); 
            #endregion
            #region By referance
            //int A = 10;
            //int B = 20;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Swap(ref A,ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            #endregion
            #endregion
            #region Reference type
            #region Ex01
            #region By value
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumOfArray(Numbers));  

            #endregion
            #region By reference
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumOfArray(ref Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #endregion
            #region EX02
            #region by Value 
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumOfArray(Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #region by Ref 
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumOfArray(ref Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #endregion

            #endregion
            #region Functions bssing by out
            //int A = 10,B=5,Sum,Mul;
            //SumMul(B,A,out Sum,out Mul);
            //Console.WriteLine(Sum);
            //Console.WriteLine(Mul);
            #endregion
            #region Function-Params
            //int[] Numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(SumOfArray( 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ));

            #endregion


            #endregion
            #region Assignment
            #region Q1
            //1- Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            #region ByValue
            //int A = 10;
            //int B = 20;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Swap(A, B);
            //Console.WriteLine(A);
            //Console.WriteLine(B); 
            #endregion
            #region By reference
            //int A = 10;
            //int B = 20;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Swap(ref A,ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            #endregion
            #endregion
            #region Q2
            //2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            #region By value
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumOfArray(Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #region By reference
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumOfArray(ref Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #endregion
            #region Q3
            //3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int x = 10;
            //int y = 5;
            //int sum ;
            //int sub ;
            //SumAndSub(x,y,out sum,out sub);
            //Console.WriteLine($"summation is = {sum} and sub is = {sub}");
            #endregion
            #region Q4
            //Console.WriteLine(SumDigits(25));
            #endregion
            #region Q5
            //5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.WriteLine(IsPrime(5)); 
            #endregion
            #region Q6
            //6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //MaxAndMinArray(ref Numbers, out int max, out int min);
            //Console.WriteLine(max);
            //Console.WriteLine(min);

            #endregion
            #region Q7
            
            //7 -Create an iterative(non-recursive) function to calculate the factorial of the number specified as parameter

            Console.WriteLine(Factorial(5));
            #endregion
            #region Q8
            //8-Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

            #endregion

            #endregion
        }
    }
}
