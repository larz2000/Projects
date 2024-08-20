using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExer2
{
    internal class DataTypesProgram
    {
        static void Main(string[] args)
        {
            int numOfApple,convToInt;//declare int variables
            double priceOfApple,totalValue;// declare double variables
            Console.Write("Enter the pieces of apple: ");//ask user
            numOfApple = Convert.ToInt32(Console.ReadLine());//input value/s
            
            if (numOfApple>0) {//if the user input 0 then the program won't execute otherwise it will execute
                Console.Write("Enter the price of each apple: ");//ask user
                priceOfApple = Convert.ToDouble(Console.ReadLine());//input values
                totalValue = priceOfApple * numOfApple;//multiply number of apple to each price
                convToInt = (int)totalValue;//convert double to int

                if (numOfApple > 1){
                    Console.WriteLine("The total price of " + numOfApple + " apples is: " + totalValue);//output
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("The value of original price is:  " + totalValue);//output
                    Console.WriteLine("The value of converted price is: "+convToInt);//output
                    Console.WriteLine("--------------------------------------------");
                }
                else {
                    Console.WriteLine("The total price of "+numOfApple+" apple is: "+totalValue);//output
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("The value of original price is:  " + totalValue);//output
                    Console.WriteLine("The value of converted price is: " + convToInt);//output
                    Console.WriteLine("--------------------------------------------");
                }

            }else{
                Console.WriteLine("YOUR INPUT MUST BE GREATER THAN 0!");
            }
        }
    }
}
