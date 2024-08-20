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
            int numOfApple,convToInt;
            double priceOfApple,totalValue;
            Console.Write("Enter the pieces of apple: ");
            numOfApple = Convert.ToInt32(Console.ReadLine());
            
            if (numOfApple>0) {
                Console.Write("Enter the price of each apple: ");
                priceOfApple = Convert.ToDouble(Console.ReadLine());
                totalValue = priceOfApple * numOfApple;
                convToInt = (int)totalValue;

                if (numOfApple > 1){
                    Console.WriteLine("The total price of " + numOfApple + " apples is: " + totalValue);
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("The value of original price is:  " + totalValue);
                    Console.WriteLine("The value of converted price is: "+convToInt);
                    Console.WriteLine("--------------------------------------------");
                }
                else {
                    Console.WriteLine("The total price of "+numOfApple+" apple is: "+totalValue);
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("The value of original price is:  " + totalValue);
                    Console.WriteLine("The value of converted price is: " + convToInt);
                    Console.WriteLine("--------------------------------------------");
                }

            }else{
                Console.WriteLine("YOUR INPUT MUST BE GREATER THAN 0!");
            }
        }
    }
}
