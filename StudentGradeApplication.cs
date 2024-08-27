using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double average;
            Console.WriteLine("Student Grade Application");
            Console.Write("\nName:   ");
            string name = Console.ReadLine();
            Console.WriteLine("\nSubjects    Grades");
            Console.Write("English :   ");
            double english = Convert.ToDouble(Console.ReadLine());
            Console.Write("Math    :   ");
            double math = Convert.ToDouble(Console.ReadLine());
            Console.Write("Science :   ");
            double science = Convert.ToDouble(Console.ReadLine());
            Console.Write("Filipino:   ");
            double filipino = Convert.ToDouble(Console.ReadLine());
            Console.Write("History :   ");
            double history = Convert.ToDouble(Console.ReadLine());

            average = (english + math + science + filipino + history)/5;

            string res = (average >= 75 ) ? "The student passed." : "The student failed.";

            Console.WriteLine("\n"+res);
            Console.WriteLine("The general average of " + name + " is: " + average+"\n");


        }
    }
}
