using System;
using System.Collections.Generic;
using System.Linq ;
using System.Text ;
using System.Threading.Tasks;

namespace DateType{

    class Program{
        static void Main(string[]args){
            
            // LONG/ SORT DATE TIME
            DateTime dt = DateTime.Now;
            Console.WriteLine("{0:d}",dt); // SHORT DATE 
            Console.WriteLine("{0:D}",dt); //LONG DATE
            Console.WriteLine("{0:f}",dt); //FULL DATE/TIME(SHORT)
            Console.WriteLine("{0:F}",dt); //FULL DATE/TIME(LONG)
             Console.WriteLine("{0:G}",dt); //GENERAL DATE/TIME(LONG)
             Console.WriteLine("{0:g}",dt); //GENERAL DATE/TIME(SHORT)
              Console.WriteLine("{0:M}",dt); //GENERAL MONTH (LONG)
             Console.WriteLine("{0:m}",dt); //GENERAL MONTH(SHORT)
             Console.WriteLine("{0:T}",dt); //GENERAL TIME(LONG)
             Console.WriteLine("{0:t}",dt); //GENERAL TIME(SHORT)
             Console.WriteLine("{0:Y}",dt); //GENERAL YEAR (LONG)
             Console.WriteLine("{0:y}",dt); //GENERAL YEAR(SHORT)
             Console.WriteLine("{0:yy}",dt); //GENERAL YEAR(LAST TWO DIGITS)
             Console.WriteLine("{0:ddd}",dt);// SHORT DAY NAME
             Console.WriteLine("{0:dddd}",dt); // LONG DATE NAME
             Console.WriteLine("{0:FF}",dt);// SECOND FUNCTION 
             Console.WriteLine("{0:HH}",dt); // HOUR
             Console.WriteLine("{0:MM}",dt);// MONTH DIGITS  
             Console.WriteLine("{0:MMM}",dt); // MONTH NAME 
             Console.WriteLine("{0:ss}",dt); // REPRESENTS THE SECOND AS A NUMBER FORM 0 TO 59
             Console.WriteLine("{0:hh:mm:ss tt}",dt);  // FULL TIME 
             Console.WriteLine("{0:dd-MM-yyyy}",dt); // FULL DATE
              Console.WriteLine("{0:dd/MM/yyyy}",dt); // FULL DATE
            //  Console.WriteLine("{0:d} {1:D}",dt,dt); //GENERAL DATE/TIME
            Console.ReadLine();
        }
    }
}