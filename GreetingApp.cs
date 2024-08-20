using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingApp
{
    internal class GreetingProgram
    {
        static void Main(string[] args)
        {
            String name;//declare string type for name variable
            int numOfCourses;// declare int type for numOfCourses variable
            double bookPrice;// declare double type for bookPrice variable
            Console.Write("Enter your name: ");//ask user
            name = Console.ReadLine();//input
            Console.Write("Enter the total number of your enrolled courses: ");//ask user
            numOfCourses = Convert.ToInt32(Console.ReadLine());//input
            Console.Write("Enter the price of your favorite book: ");//ask user
            bookPrice = Convert.ToDouble(Console.ReadLine());//input
            Console.WriteLine("Name: "+name+"\nTotal enrolled courses: "+numOfCourses+"\nPrice of my favorite book: "+bookPrice);//output
        }
    }
}
