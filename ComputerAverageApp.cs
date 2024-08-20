using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerAverageApp
{
    internal class ComputerAverageProgram
    {
        static void Main(string[] args)
        {
            double sumOfGrades=0;//initialize
            Console.Write("Enter student's name: ");//ask user
            string name = Console.ReadLine();//input
            Console.Write("Enter the number of subject/s: ");//ask user
            int numSubs = Convert.ToInt32(Console.ReadLine());//input
            Console.WriteLine("Enter grade for each subject/s: ");//ask user
            for (int i=0;i<numSubs;i++){//loop input by the number of subjects
                sumOfGrades = sumOfGrades + Convert.ToDouble(Console.ReadLine());
            }
            double ave = sumOfGrades/numSubs;//divide the sum of grades to the number of subjects to get the average
            double rounded = Math.Round(ave);//round the average 
            Console.WriteLine("The average grade of "+name+" is: "+ave);//output
            Console.WriteLine("The final grade rounded off is: "+rounded);//output
        }
    }
}
