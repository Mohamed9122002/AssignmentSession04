using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

namespace AssignmentSession04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1 - Write a program that allows the user to insert an integer then print all numbers
            //    between 1 to that number.
            //int num;
            //Console.WriteLine("enter a number:");
            //num = int.Parse(Console.ReadLine());


            //for (int i = 1; i <= num; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Q02
            //2 - Write a program that allows the user to insert an integer then
            //    print a multiplication table up to 12
            //bool Flag;
            //int Number;
            //do
            //{
            //    Console.WriteLine("Please Enter Number");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //} while(!Flag);
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($" Print Table Up To 12 { Number * i}");
            //}
            #endregion
            
            #region Q3
            //3 - Write a program that allows to user to insert number then print all even numbers
            //    between 1 to this number
            //int num;
            //Console.WriteLine("enter a number:");
            //num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    if(i % 2 ==0)
            //        Console.WriteLine(i);
            //}
            #endregion

            #region Q4 
            //4 - Write a program that takes two integers then prints the power.
            //int num,power,result=1;


            //Console.WriteLine("enter base number:");
            //num = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter power number:");
            //power = int.Parse(Console.ReadLine());

            //for (int i = 1; i <=power; i++)
            //{
            //    result *= num;
            //}
            //Console.WriteLine(result);
            #endregion
            #region Q5  
            //5 - Write a program to enter marks of five subjects and calculate total, average and percentage.

            //// Input: -Enter Marks of five subjects: 95 76 58 90 89
            ////Output: Total marks = 408
            ////Average Marks = 81
            ////Percentage = 81

            //double num, sum = 0,avg =0, percent=0;
            //int count = 0;
            //while(count <5)
            //{
            //    Console.WriteLine($"enter marks of subject{count+1}");
            //    num = int.Parse( Console.ReadLine() );

            //    if(num >=0 && num <=100)
            //    {
            //        sum += num;
            //        count++;
            //    }
            //    else
            //        Console.WriteLine("invalid");

            //}
            //avg = sum / 5;
            //percent = (sum * 100) / 500;
            //Console.WriteLine($"Total: {sum}");
            //Console.WriteLine($"average: {avg}");

            //Console.WriteLine($"percent: {percent}");

            #endregion

            #region Q6
            //6 - Write a program to input the month number and print the number of days in that month.
            //int num;
            //Console.WriteLine("enter month number:");
            //num = int.Parse(Console.ReadLine());

            //switch (num)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("number of days 31");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("number of days 30");
            //        break;
            //    case 2:
            //        Console.WriteLine("number of days 28");
            //        break;
            //    default:
            //        Console.WriteLine("invalid");
            //        break;


            //}
            #endregion
            #region Q7
            //7 - Write a program to create a Simple Calculator.
            //int num1,num2;
            //char op;
            //double result = 0;

            //Console.WriteLine("enter 1st number:");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter 2nd number:");
            //num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter operation:");
            //op = char.Parse(Console.ReadLine());

            //switch (op)
            //{
            //    case '+':
            //        result = num1+ num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        if(num2 ==0)
            //        {
            //            Console.WriteLine("cannot divid by zero");
            //            break;
            //        }
            //        else
            //            result= num1 / num2;
            //        break;
            //        default: 
            //        Console.WriteLine("Invalid operation");
            //        break;


            //}
            //Console.WriteLine(result);
            #endregion
            #region Q8
            //8 - Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.WriteLine("enter a string");
            //string st = Console.ReadLine();
            //for (int i = st.Length -1 ; i >=0 ; i--)
            //{
            //    Console.Write(st[i]);
            //}
            #endregion
            #region Q9
            //9 - Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.WriteLine("enter start number");
            //int start = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter end number");
            //int end = int.Parse(Console.ReadLine());

            //for(int i = start ; i <= end; i++)
            //{
            //    for (int j = 2; j < i; j++)
            //    {
            //        if(i % j == 0)
            //        {
            //            Console.WriteLine($"{i} is not prime");

            //        }

            //    }
            //    Console.WriteLine($"{i} is Prime");
            //}
            #endregion

            #region Q10
            //10 - .Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.WriteLine("enter a number");
            //int num = int.Parse(Console.ReadLine());

            //string st = "";

            //int result = num;

            //while (result > 0)
            //{
            //    if (result % 2 == 0)
            //    {
            //        st += "1";
            //        result /= 2;
            //    }
            //    else
            //    {


            //        st += "0";
            //        result /= 2;
            //    }

            //}
            //Console.WriteLine(st);
            #endregion
        }
    }
}
