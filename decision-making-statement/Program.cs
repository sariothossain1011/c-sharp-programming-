using System;

namespace decisionMakingStatement
{

    class Program
    {
        static void Main(string[] args)
        {

            // IF-ELSE ********

            // int a = 20;
            // int b = 40;
            // if (a > b)
            // {
            //     Console.WriteLine("a greater then equal b");
            // }
            // else
            // {
            //     Console.WriteLine("a less then equal b");
            // }


            //IF-ELSE-IF ********

            // int mark = 0;
            // if (mark >= 80)
            // {
            //     Console.WriteLine("Grade is A+");
            // }
            // else if (mark >= 70)
            // {
            //     Console.WriteLine("Grade is A");
            // }
            // else if (mark >= 60)
            // {
            //     Console.WriteLine("Grade is A-");
            // }
            // else if (mark >= 50)
            // {
            //     Console.WriteLine("Grade is A-");
            // }
            // else if (mark >= 40)
            // {
            //     Console.WriteLine("Grade is B");
            // }
            // else if (mark >= 33)
            // {
            //     Console.WriteLine("Grade is c");
            // }
            // else
            // {
            //     Console.WriteLine("you are fail!");
            // }


            // NESTED IF ********

            // Console.WriteLine("Enter your E-mail:");
            // string email = Console.ReadLine();
            // if (email == "sariot@gmail.com")
            // {
            //     Console.WriteLine("Enter your password:");
            //     string password = Console.ReadLine();
            //     if (password == "sariot")
            //     {
            //         Console.WriteLine("login successfuly");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Wrong password!");
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("Invalid your email!");
            // }


            // SWITCH STATEMENT ********

            // Console.WriteLine("Enter your character");
            // string letter = Console.ReadLine();
            // switch(letter){
            //     // FIRST WARY WITH SHORTLY
            //     case "a":
            //     case "e":
            //     case "i":
            //     case "o":
            //     case "y":
            //     Console.WriteLine("wow! This is a vowel");
            //     break;
            //     // SECOND WARY WITH LENGTHY
            //     // case "a":
            //     // Console.WriteLine("wow! This is a vowel");
            //     // break;
            //     // case "e":
            //     // Console.WriteLine("wow! This is a vowel");
            //     // break;
            //     // case "i":
            //     // Console.WriteLine("wow! This is a vowel");
            //     // break;
            //     // case "o":
            //     // Console.WriteLine("wow! This is a vowel");
            //     // break;
            //     // case "u":
            //     // Console.WriteLine("wow! This is a vowel");
            //     // break;
            //     default :
            //     Console.WriteLine("wow! This is not a vowel");
            //     break;
            // }


            // NESTED SWITCH STATEMENT 

            // Console.WriteLine("what do you like eat:");
            // string categoryName = Console.ReadLine().ToLower();
            // switch (categoryName)
            // {
            //     case "rich":
            //         Console.WriteLine("Order your food:");
            //         string riceItem = Console.ReadLine().ToLower();
            //         switch (riceItem)
            //         {
            //             case "chicken":
            //                 Console.WriteLine("Your order done: Chicken");
            //                 break;
            //             case "fridge-rice":
            //                 Console.WriteLine("Your order done: Fridge Rice");
            //                 break;
            //             default:
            //                 Console.WriteLine("Your order UnValid !");
            //                 break;
            //         }
            //         break;
            //     case "Snack":
            //         Console.WriteLine("Order your food:");
            //         string item = Console.ReadLine().ToLower();
            //         switch (item)
            //         {
            //             case "bagger":
            //                 Console.WriteLine("Your order done: Bagger");
            //                 break;
            //             case "orange-juice":
            //                 Console.WriteLine("Your order done: Orange Juice");
            //                 break;
            //             default:
            //                 Console.WriteLine("Your order UnValid !");
            //                 break;
            //         }
            //         break;
            //     default:
            //         Console.WriteLine("Your order category does not existing!");
            //         break;
            // }


            // FOR LOOPING 

            // for(int i = 0 ;i <= 10; i++){
            //     Console.WriteLine();
            // }


            //NESTED FOR LOOPING 

            // for (int i = 0; i <= 10; i++)
            // {
            //     Console.WriteLine("HELLO");
            //     for (int J = 0; J <= 3; J++)
            //     {
            //         Console.WriteLine("HEY");
            //     }
            // }


            // MULTIPLICATION NUMBERS

            // Console.WriteLine("Enter your number:");
            // int num = int.Parse(Console.ReadLine().ToLower());
            // for(int i = 1 ;i <= 10; i++){
            //     Console.WriteLine(num +" X "+i +" = "+ num *i);
            // }


            // WHILE LOOP 

            // int i = 0;
            // while (i < 10)
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }


            // DO WHILE LOOP 

            // int i = 0;
            // do{
            //     Console.WriteLine(i);
            //     i++;
            // }
            // while (i <=200);


            // JUMP STATEMENT 

            // for (int i = 1; i <= 10; i++)
            // {
            //     if (i % 2 == 1)
            //     {
            //         continue;
            //     }
            //     Console.WriteLine(i);
            // }


            // GOTO STATEMENT

            // for (int i = 1; i <= 10; i++)
            // {
            //     if (i==5)
            //     {
            //         goto stop;
            //     }
            //     Console.WriteLine(i);
            // }
            // stop:
            // Console.WriteLine("existing!");





            Console.ReadKey();

        }
    }

}