﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StudentRegistrationApp
{
    internal class StudentRegistrationProgram
    {
        string[] notSubmittedFiles; //instance array variable for the files that isn't submitted
        bool outerloop = true;//flag
        bool innerLoop1 = true;//flag
        bool innerLoop2 = true;//flag
        bool innerLoop3 = true;//flag
        bool innerLoop4 = true;//flag

        static void Main(string[] args)
        {
            StudentRegistrationProgram srp = new StudentRegistrationProgram();//object
            int enableChoices = 0;//just a switch to prompt a message

            string directoryPath = @"D:\CredentialsDummy"; //directory path
            string[] filesToCheck = {"form137.pdf", "form138.xlsx", "GoodMoral.pdf", "MedicalCertificate.pdf", "PSABirthCertificate.pdf"};//files to check
            string[] checkRequirements = { "Form 137", "Form 138", "Good Moral", "Medical Certificate", "PSA Birth Certificate" };
            string[] courses = {"Bachelor of Science in Computer Science (BSCS)", "Bachelor of Science in Information Technology (BSIT)", "Bachelor of Science in Hotel Management (BSHM)",
                                "Bachelor of Science in Acountancy (BSA)","Bachelor in Multimedia Arts (BMMA)","Bachelor of Science in Business Administration (BSBA)","Bachelor of Science in Tourism Management (BSTM)",
                                "Bachelor of Arts in Communication (BACOMM)"};//list of courses

            string[] courseKeyword = { "BSCS", "BSIT", "BSHM", "BSA", "BMMA", "BSBA", "BSTM", "BACOMM" };//list of courses in keyword

            Console.WriteLine("Student Registration\n");

            while (srp.outerloop)//will repeat if you enter invalid condition
            {
                Console.Write("Do you want to enroll this semester? (yes/no): ");//ask user
                string choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "yes":

                        if (enableChoices == 0)//this is will print the choices if the value is 0
                        {
                            Console.WriteLine("\n------------------------------------------------------");
                            Console.WriteLine("\nChoose Course:\n");
                            foreach (string c in courses)//print list of available course
                            {
                                Console.WriteLine(c);
                            }
                        }

                        Console.WriteLine("\n------------------------------------------------------\n");
                        while (srp.innerLoop1)//will repeat if you enter invalid condition
                        {
                            Console.Write("Enter the keyword only: ");//ask user
                            string yourCourse = Console.ReadLine().ToUpper();
                            enableChoices = 1;// to prevent printing the list of courses when invalid input occurs

                            if (srp.checkCourse(courseKeyword, yourCourse))//check if the course is existing
                            {
                                Console.Write("\nEnter your name: ");//ask user
                                string name = Console.ReadLine().ToUpper();//input
                                Console.WriteLine("\n------------------------------------------------------");
                                Console.WriteLine("\nYou have to submit the following requirements:\n");
                                foreach (string s in checkRequirements) {// print the requirements
                                    Console.WriteLine(s);
                                }

                                while (srp.innerLoop2)//will repeat if you enter invalid condition
                                {
                                    Console.Write("\nDo you submit the requirements already? (yes/no): ");//ask user
                                    string confirm = Console.ReadLine().ToLower();
                                    
                                    switch (confirm) {
                                        case "yes":
                                            if (srp.checkReq(directoryPath, filesToCheck,checkRequirements))//
                                            {
                                                Console.WriteLine("\n------------------------------------------------------");
                                                Console.WriteLine("\nYour tuition fee is 36,000 PHP.");
                                                Console.WriteLine("Choose your MOP:\n\nPress I for Installment\nPress C for Cash\nPress any to cancel enrollment");
     
                                                Console.Write("Enter: ");
                                                string mop = Console.ReadLine().ToUpper();
                                                switch (mop)
                                                {
                                                    case "I":

                                                    Console.WriteLine("\nDown Payment: 10,000 PHP");
                                                    Console.WriteLine("Per term: 6,500 PHP x 4 terms");
                                                            
                                                    while (srp.innerLoop4)//will repeat if you enter invalid condition
                                                    {
                                                        Console.Write("\nDo you accept the conditions?(y/n): ");
                                                        string con = Console.ReadLine().ToLower();
                                                        switch (con)
                                                        {
                                                            case "y":
                                                                Console.WriteLine("\nCongratulations " + name + "! You are now enrolled in " + yourCourse);
                                                                srp.outerloop = false;
                                                                srp.innerLoop1 = false;
                                                                srp.innerLoop2 = false;        
                                                                srp.innerLoop4 = false;
                                                                break;

                                                            case "n":
                                                                Console.WriteLine("\nWe understand you, please visit us next time.");
                                                                srp.outerloop = false;
                                                                srp.innerLoop1 = false;
                                                                srp.innerLoop2 = false;  
                                                                srp.innerLoop4 = false;
                                                                break;

                                                            default:
                                                                Console.WriteLine("Invalid input!!!");
                                                                break;
                                                            }
                                                        }
                                                        Console.WriteLine("\n------------------------------------------------------");
                                                        break;

                                                    case "C":

                                                        Console.WriteLine("\nFull Payment: 36,000 PHP");
                                                            
                                                        while (srp.innerLoop4)//will repeat if you enter invalid condition
                                                        {
                                                            Console.Write("\nDo you accept the conditions?(y/n): ");
                                                            string con1 = Console.ReadLine().ToLower();
                                                            switch (con1)
                                                            {
                                                                case "y":
                                                                    Console.WriteLine("\nCongratulations " + name + "! You are now enrolled in " + yourCourse);
                                                                    srp.outerloop = false;
                                                                    srp.innerLoop1 = false;
                                                                    srp.innerLoop2 = false;
                                                                    srp.innerLoop4 = false;
                                                                    break;

                                                                case "n":
                                                                    Console.WriteLine("\nWe understand you, please visit us next time.");
                                                                    srp.outerloop = false;
                                                                    srp.innerLoop1 = false;
                                                                    srp.innerLoop2 = false;  
                                                                    srp.innerLoop4 = false;
                                                                    break;

                                                                default:
                                                                    Console.WriteLine("Invalid input!!!");
                                                                    break;
                                                            }
                                                        }
                                                        Console.WriteLine("\n------------------------------------------------------");
                                                        break;

                                                    default:
                                                        Console.WriteLine("\nWe understand you, please visit us next time.");
                                                        Console.WriteLine("\n------------------------------------------------------");
                                                        srp.outerloop = false;
                                                        srp.innerLoop1 = false;
                                                        srp.innerLoop2 = false;
                                                        break;
                                                }
                                                srp.outerloop = false;
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nSorry your credentials are incomplete.\nYour enrollment will be posponed.\n\nYou must complete the following:\n");
                                                foreach (string nef in srp.notSubmittedFiles)
                                                {
                                                    Console.WriteLine(nef);
                                                }
                                                Console.WriteLine("\n------------------------------------------------------\n");
                                                srp.outerloop = false;
                                                srp.innerLoop1 = false;
                                                srp.innerLoop2 = false;
                                            }
                                            break;

                                        case "no":

                                            Console.WriteLine("\nComeback again if you completed the requirements.\n");
                                            srp.outerloop = false;
                                            srp.innerLoop1 = false;
                                            srp.innerLoop2 = false;
                                            break;
                                        default:
                                            Console.WriteLine("Invalid input!");
                                            Console.WriteLine("\n------------------------------------------------------");
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid Course");
                            }
                        }
                        break;

                    case "no":

                        Console.WriteLine("Comeback whenever you're ready.");
                        srp.outerloop = false;
                        break;

                    default:

                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
        }

        bool checkCourse(string[] ck, string yc)
        {
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
        bool checkReq(string dp, string[] ftc, string[] cr)
        {
            bool a = false;
            int numOfFiles = 0;
            int i=0;
            int j = 0;
            foreach (string fileName in ftc)
            {
                string filePath = Path.Combine(dp, fileName);
                if (File.Exists(filePath))
                {
                    numOfFiles++;   
                }  
            }
            a = numOfFiles != ftc.Length ? false : true;

            if (numOfFiles != ftc.Length) {
                
                int numOfUnsubmitted = ftc.Length - numOfFiles;
                notSubmittedFiles = new string[numOfUnsubmitted];

                foreach (string fileName in ftc) {
                    string filePath = Path.Combine(dp, fileName);
                    if (!(File.Exists(filePath)))
                    {
                        notSubmittedFiles[j] = (j+1)+". "+cr[i];
                        j++;
                    }
                    i++;
                }

                
            }
            return a;
        }

    }
}
