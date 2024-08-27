using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int e = 0;
            string directoryPath = @"C:\Users\johnb\OneDrive\Documents\Requirements";
            string[] filesToCheck = { "GoodMoral.pdf", "form137.pdf", "grades.xlsx", "PSA.pdf" };

            string[] courses = {"Bachelor of Science in Computer Science (BSCS)", "Bachelor of Science in Information Technology (BSIT)", "Bachelor of Science in Hotel Management (BSHM)",
                                "Bachelor of Science in Acountancy (BSA)","Bachelor in Multimedia Arts (BMMA)","Bachelor of Science in Business Administration (BSBA)","Bachelor of Science in Tourism Management (BSTM)",
                                "Bachelor of Arts in Communication (BACOMM)"};

            string[] courseKeyword = { "BSCS", "BSIT", "BSHM", "BSA", "BMMA", "BSBA", "BSTM", "BACOMM" };

            Console.WriteLine("Student Registration\n");
            Console.Write("Do you want to enroll? (yes/no): ");
            string choice = Console.ReadLine().ToLower();

            bool outerloop1 = true;
            while (outerloop1) {
                switch (choice) {
                    case "yes":

                        if (e == 0) {
                            Console.WriteLine("Choose Course:");
                            foreach (string c in courses)
                            {
                                Console.WriteLine(c);
                            }
                        }

                        Console.Write("\nEnter the keyword only: ");
                        string yourCourse = Console.ReadLine().ToUpper();
                        e = 1;
                        if (p.checkCourse(courseKeyword, yourCourse))
                        {
                            Console.Write("Enter your name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("\nYou have to submit the following requirements: \nGood moral\nForm 137\nPSA\nMedCert\nSHS grades");
                            Console.Write("Do you submit the requirements already? (yes/no): ");
                            string confirm = Console.ReadLine();
                            if (confirm == "yes")
                            {
                                if (p.checkReq(directoryPath, filesToCheck))
                                {
                                    Console.WriteLine("You have enrolled successfully!!!");
                                    outerloop1 = false;
                                }
                                else
                                {
                                    Console.WriteLine("You have passed nothing or incomplete.\nComeback again if you completed the requirements.");
                                    outerloop1 = false;
                                }
                            }
                            else {
                                Console.WriteLine("Comeback again if you completed the requirements.");
                                outerloop1 = false;
                            }
                            

                        }
                        else {
                            Console.WriteLine("Invalid Course");
                        }
                        break;
                }
            }
            
        }
        bool checkCourse(string[] ck,string yc) {
            bool a = false;
            for (int i = 0; i < ck.Length; i++)
            {
                if (yc == ck[i])
                {
                    a = true;
                }
            }
            return a;
        }
        bool checkReq(string dp, string[] ftc) {
            bool a = false;
            foreach (string fileName in ftc)
            {
                string filePath = Path.Combine(dp, fileName);
                if (File.Exists(filePath))
                {
                    a = true;
                }
            }
            return a;
            
        }
        
    }
}
