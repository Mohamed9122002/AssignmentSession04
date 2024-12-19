using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession04
{
    internal class Demo
    {

        #region Evolution of switch in C# versions

        #region C# 7.0 [Pattern matching - case guards (when)]
        // object input = 6.4; // boxing 

        #region Example 01 [pattern matching on types]

        //switch (input)
        //{
        //    // No Jump Table will be generated
        //    case int value:
        //        Console.WriteLine("Integer");
        //        break;

        //    case decimal value:
        //        Console.WriteLine("Decimal");
        //        break;
        //    case double value:
        //        Console.WriteLine("Double");
        //        break;
        //    default:
        //        Console.WriteLine("No Matching");
        //        break;
        //}

        #endregion

        #region Example 02 [Case Guards (when)]
        //switch (input)
        //{
        //    // No Jump Table will be generated
        //    case int value when value < 10: // unboxing
        //        Console.WriteLine("Integer is less than 10");
        //        break;
        //    case int value when value > 10: // unboxing
        //        Console.WriteLine("Integer is more than 10");
        //        break;
        //    case decimal value:
        //        Console.WriteLine("Decimal");
        //        break;
        //    case double value when value > 5.5 && value < 10.10:
        //        Console.WriteLine("Double");
        //        break;
        //    default:
        //        Console.WriteLine("No Matching");
        //        break;
        //}

        #endregion

        #region Example 03 [User-Defined data type]
        //Person person;
        // 4 bytes at stack 
        // 0 bytes at heap
        // ref  => person , inherit person
        // person = new Person() { Id = 10, Name = "Hamada", Age = 25 };
        // 1. allocate required bytes at heap 
        // 2. initialize bytes with deafult value
        // 3. call user defined constructor
        // 4. ref => object 

        //switch (person)
        //{
        //    case int value when value > 10:
        //        Console.WriteLine("int greater than 10 ");
        //        break;
        //    case string value:
        //        Console.WriteLine("string");
        //        break;
        //    case Person value when value.Id == 10 && value.Name == "Omar":
        //        Console.WriteLine("Person with id : 10 and name : omar");
        //        break;

        //    default:
        //        Console.WriteLine("No Matching");
        //        break;
        //}


        #endregion



        #endregion

        #region C# 8.0 [Patten Matching without alias name - switch expression[constant pattern - discard pattern - property pattern] - nullable type - relational pattern [partial]]
        #region Example 01 Patten Matching without alias name
        //switch (input)
        //{
        //    // No Jump Table will be generated
        //    case int:
        //        Console.WriteLine("Integer");
        //        break;
        //    case decimal:
        //        Console.WriteLine("Decimal");
        //        break;
        //    case double when (double)input > 5.5 && (double)input < 10.10:
        //        Console.WriteLine("Double");
        //        break;
        //    default:
        //        Console.WriteLine("No Matching");
        //        break;
        //}


        #endregion

        #region Without Swich Expression
        //string option = Console.ReadLine();
        //string msg = null;
        //switch (option)
        //{
        //    case "1":
        //        // Console.WriteLine("Option 01");
        //        msg = "Option 01";
        //        break;
        //    case "2":
        //        // Console.WriteLine("Option 02");
        //        msg = "Option 02";

        //        break;
        //    case "3":
        //        msg = "Option 03";
        //       // Console.WriteLine("Option 03");
        //        break;
        //    default:
        //        Console.WriteLine("Invalid option");
        //        break;
        //}
        //Console.WriteLine(msg);

        #endregion

        #region Example 02 Switch Expression [Constatnt Pattern - Discard Pattern]

        //string option = Console.ReadLine();
        //string msg = option switch
        //{
        //    "1" => "Option 01",
        //    "2" => "Option 02",
        //    "3" => "Option 03",
        //    _   => "Invalid Option"
        //};
        //Console.WriteLine(msg);
        #endregion

        #region Example 03 Switch Expression [Property Pattern]
        //Person person = new Person() { Id = 100, Name = "Hamada", Age = 25 };

        //string result = person switch
        //{
        //    { Name: "Hamada" , Id : 10} => "Name = hamada , id = 10",
        //    { Name : "Omar" , Age : 25} => "Name = omar , age = 25",
        //    { Id : 20} => "id = 20",
        //    _ => "ay hagaaaaa"
        //};
        //Console.WriteLine(result);
        #endregion

        #region Example 04 [Nullable Type  - relational pattern]

        /// number = null  => nullable type 
        /// number = 1     => positive number
        /// number = -1    => negative number
        /// number = 0     => zero
        /// 

        //int? number = null;
        //string result = number switch
        //{
        //    null => "nullable type ",
        //    int when number > 0  => "positive number",
        //    int when number < 0 => "negative number",
        //    0 => "Zero"

        //};
        //Console.WriteLine(result);


        #endregion

        #endregion

        #region C# 9.0 [Switch Expression with relational pattern - logical pattern - enhancement property pattern]
        #region Example 01  [relational pattern (> , < , >= , <=)]
        /// number less than 10
        /// number between 10 and 20 
        /// number greater than 20

        //int number = 20;
        //string result = number switch
        //{
        //    < 10 => "less than 10",
        //    >= 10 and <= 20 => "number between 10 and 20 ",
        //    > 20 => "number greater than 20"

        //};
        //Console.WriteLine(result);
        #endregion

        #region Example 02 [Logical Pattern (and - or)]
        /// number Between 1 and 9
        /// number between 10 and 20 
        /// number is zero 
        /// number outside range

        //int number = 50;
        //string result = number switch
        //{
        //    > 0 and < 10 => "number Between 1 and 9 ",
        //    >= 10 and <= 20 => " number between 10 and 20 ",
        //    0 => "number is zero ",
        //    > 20 or < 0 => "number outside range"
        //};
        //Console.WriteLine(result);

        #endregion

        #region Exapmle 03 [Enhanced Proprty Pattern]
        /// Person is samy and his age is greater than 10
        /// Person is omar and his age between 20 and 25
        /// person'age is between 50 and 60 
        /// [sorry but we don't know you]

        //Person person = new Person() { Id = 10, Name = "Hamada", Age = 55 };
        //string result = person switch
        //{

        //    { Name: "Samy", Age: > 10 } => "Person is samy and his age is greater than 10",
        //    { Name: "Omar", Age: >= 20 and <= 25 } => "Person is omar and his age between 20 and 25",
        //    { Age: > 50 and < 60 } => "Hello Old man",
        //    _ => "sorry but we don't know you"
        //};
        //Console.WriteLine(result);
        #endregion
        #endregion
        #endregion

        #region Loop Statement
        #region Introduce
        //Console.WriteLine(1);
        //Console.WriteLine(2);
        //Console.WriteLine(3);
        //Console.WriteLine(4);
        //Console.WriteLine(5);
        //Console.WriteLine(6);
        //Console.WriteLine(7);
        //Console.WriteLine(8);
        //Console.WriteLine(9);
        //Console.WriteLine(10);

        //for(int i = 1; i <= 100; i++)
        //    Console.WriteLine(i + 1); 
        #endregion


        #region For - Foreach

        //                0  1  2  3  4
        // int[] numbers = { 1, 2, 3, 4,5,6,7 };

        //for (int i = 0; i <= 5; i++)
        //{
        //    // numbers[i] += 10;
        //    if (i == 2)
        //        // continue; // skip current iteration
        //        break; // Exit from loop
        //    Console.WriteLine(numbers[i]);
        //}

        //Console.WriteLine("///////////////////////////////");
        //foreach (int item in numbers)
        //{
        //    //item += 10; invalid

        //    Console.WriteLine(item);
        //}
        #endregion

        #region While - Do While

        #region Do-While
        /// if value is odd number => enter value again 
        /// if value is not a number => enter value again
        /// if value is even number => print number

        //bool flag;
        //int number;
        //do
        //{
        //    Console.WriteLine("Please Enter Even Number ");
        //    flag = int.TryParse(Console.ReadLine(), out number); // hamada flag = false !flag = true
        //                                                         // 10  flag = true !flag = false
        //                                                         // 11 odd number 11/2 = 5*2=10 11-10=1 
        //} while (!flag || number % 2 == 1);
        //Console.WriteLine(number);
        #endregion

        #region While

        /// take from user number and print sequance from entered number to 10
        /// 5 => 5,6,7,8,9,10
        /// 2 => 2,3,4,5,6,7,8,9,10

        //Console.WriteLine("Enter number");
        //int.TryParse(Console.ReadLine(), out int result); //2 

        //    while (result <= 10)
        //    {
        //        Console.WriteLine(result);
        //        result++;
        //    }


        //for (int i = result; i <=10; i++)
        //{
        //    Console.WriteLine(i);
        //}

        #endregion



        #endregion

        #endregion

    }
}
