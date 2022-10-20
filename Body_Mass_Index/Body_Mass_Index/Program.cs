using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Body_Mass_Index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bmi = 0;
            Console.WriteLine("                                *");
            Console.WriteLine("                             **   **");
            Console.WriteLine("                          ***       ***");
            Console.WriteLine("                       *** WELCOME BMI ***");
            Console.WriteLine("                          ***       ***");
            Console.WriteLine("                             **   **");
            Console.WriteLine("                                *");
            Console.WriteLine();
           
            Console.WriteLine();
            Console.Write("How many people would you like to measure their body mass index: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string[] person = new string[number];


            for (int i = 0; i < person.Length; i++)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("******************** BMI ********************");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("What's your gender: F / M: ");
                char gender = Convert.ToChar(Console.ReadLine());
                Console.Write("Please enter your name: ");
                person[i] = Console.ReadLine();
                Console.Write("Age: ");
                double age = Convert.ToDouble(Console.ReadLine());
                Console.Write("What's your kg: ");
                double kg = Convert.ToDouble(Console.ReadLine());
                Console.Write("What's your height (Example:1,70):  ");
                double height = Convert.ToDouble(Console.ReadLine());

                if (gender == 'F' || gender == 'f')
                {
                    if (age >= 19 && age <= 24)
                    {
                        Console.WriteLine();
                        bmi = kg / (height * height);
                        Console.WriteLine("Ideal BMI for your age: Between 19-24");


                        if (bmi < 19)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("UNDERWEIGHT");
                        }
                        else if (bmi >= 19 && bmi < 25)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("NORMAL");
                        }
                        else if (bmi >= 25 && bmi < 30)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("OVERWEIGHT");
                        }
                        else if (bmi >= 30 && bmi < 35)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("OBESE");
                        }
                        else if (bmi >= 35)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("EXTREMLY OBESE");
                        }

                    }
                    else if (age >= 25 && age < 35)
                    {
                        Console.WriteLine();
                        bmi = kg / (height * height);
                        Console.WriteLine("Ideal BMI for your age: Between 20-25");


                        if (bmi < 20)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("UNDERWEIGHT");
                        }
                        else if (bmi >= 20 && bmi < 25)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("NORMAL");
                        }
                        else if (bmi >= 25 && bmi < 30)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("OVERWEIGHT");
                        }
                        else if (bmi >= 30 && bmi < 35)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("OBESE");
                        }
                        else if (bmi >= 35)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("EXTREMLY OBESE");
                        }

                    }
                    else if (age >= 35 && age < 45)
                    {
                        Console.WriteLine();
                        bmi = kg / (height * height);
                        Console.WriteLine("Ideal BMI for your age: Between 21-26");


                        if (bmi < 21)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("UNDERWEIGHT");
                        }
                        else if (bmi >= 21 && bmi < 26)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("NORMAL");
                        }
                        else if (bmi >= 26 && bmi < 31)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("OVERWEIGHT");
                        }
                        else if (bmi >= 31 && bmi < 36)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("OBESE");
                        }
                        else if (bmi >= 36)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("EXTREMLY OBESE");
                        }

                    }
                    else if (age >= 45 && age < 55)
                    {
                        Console.WriteLine();
                        bmi = kg / (height * height);
                        Console.WriteLine("Ideal BMI for your age: Between 22-27");


                        if (bmi < 22)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("UNDERWEIGHT");
                        }
                        else if (bmi >= 22 && bmi < 27)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("NORMAL");
                        }
                        else if (bmi >= 27 && bmi < 32)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("OVERWEIGHT");
                        }
                        else if (bmi >= 32 && bmi < 37)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("OBESE");
                        }
                        else if (bmi >= 37)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("EXTREMLY OBESE");
                        }

                    }
                    else if (age >= 55 && age < 65)
                    {
                        Console.WriteLine();
                        bmi = kg / (height * height);
                        Console.WriteLine("Ideal BMI for your age: Between 23-28");


                        if (bmi < 23)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("UNDERWEIGHT");
                        }
                        else if (bmi >= 23 && bmi < 28)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("NORMAL");
                        }
                        else if (bmi >= 28 && bmi < 33)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("OVERWEIGHT");
                        }
                        else if (bmi >= 33 && bmi < 38)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("OBESE");
                        }
                        else if (bmi >= 38)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("EXTREMLY OBESE");
                        }

                    }
                    else if (age >= 65)
                    {
                        Console.WriteLine();
                        bmi = kg / (height * height);
                        Console.WriteLine("Ideal BMI for your age: Between 24-29");


                        if (bmi < 24)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("UNDERWEIGHT");
                        }
                        else if (bmi >= 24 && bmi < 29)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("NORMAL");
                        }
                        else if (bmi >= 29 && bmi < 34)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("OVERWEIGHT");
                        }
                        else if (bmi >= 34 && bmi < 39)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("OBESE");
                        }
                        else if (bmi >= 39)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("EXTREMLY OBESE");
                        }

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Although the calculation method of height weight index for 2 to 18 year olds and children is done in the same way, the results are evaluated differently.\n Even if two children have exactly the same BMI, it can be seen that one is obese and the other is at ideal weight.\n In other words, since height and weight index in this age group differs according to age and gender,\n it is recommended that the measurement be made by a specialist dietitian or pediatrician.");
                        continue;
                    }
                }
                else if (gender == 'M' || gender == 'm')
                {
                    if (age >= 19 && age <= 24)
                    {
                        Console.WriteLine();
                        bmi = kg / (height * height);
                        Console.WriteLine("Ideal BMI for your age: Between 19-24");


                        if (bmi < 19)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("UNDERWEIGHT");
                        }
                        else if (bmi >= 19 && bmi < 25)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("NORMAL");
                        }
                        else if (bmi >= 25 && bmi < 30)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("OVERWEIGHT");
                        }
                        else if (bmi >= 30 && bmi < 35)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("OBESE");
                        }
                        else if (bmi >= 35)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("EXTREMLY OBESE");
                        }

                    }
                    else if (age >= 25 && age < 35)
                    {
                        Console.WriteLine();
                        bmi = kg / (height * height);
                        Console.WriteLine("Ideal BMI for your age: Between 20-25");


                        if (bmi < 20)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("UNDERWEIGHT");
                        }
                        else if (bmi >= 20 && bmi < 25)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("NORMAL");
                        }
                        else if (bmi >= 25 && bmi < 30)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("OVERWEIGHT");
                        }
                        else if (bmi >= 30 && bmi < 35)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("OBESE");
                        }
                        else if (bmi >= 35)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("EXTREMLY OBESE");
                        }

                    }
                    else if (age >= 35 && age < 45)
                    {
                        Console.WriteLine();
                        bmi = kg / (height * height);
                        Console.WriteLine("Ideal BMI for your age: Between 21-26");


                        if (bmi < 21)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("UNDERWEIGHT");
                        }
                        else if (bmi >= 21 && bmi < 26)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("NORMAL");
                        }
                        else if (bmi >= 26 && bmi < 31)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("OVERWEIGHT");
                        }
                        else if (bmi >= 31 && bmi < 36)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("OBESE");
                        }
                        else if (bmi >= 36)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("EXTREMLY OBESE");
                        }

                    }
                    else if (age >= 45 && age < 55)
                    {
                        Console.WriteLine();
                        bmi = kg / (height * height);
                        Console.WriteLine("Ideal BMI for your age: Between 22-27");


                        if (bmi < 22)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("UNDERWEIGHT");
                        }
                        else if (bmi >= 22 && bmi < 27)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("NORMAL");
                        }
                        else if (bmi >= 27 && bmi < 32)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("OVERWEIGHT");
                        }
                        else if (bmi >= 32 && bmi < 37)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("OBESE");
                        }
                        else if (bmi >= 37)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("EXTREMLY OBESE");
                        }

                    }
                    else if (age >= 55 && age < 65)
                    {

                        Console.WriteLine();
                        bmi = kg / (height * height);
                        Console.WriteLine("Ideal BMI for your age: Between 23-28");


                        if (bmi < 23)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("UNDERWEIGHT");
                        }
                        else if (bmi >= 23 && bmi < 28)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("NORMAL");
                        }
                        else if (bmi >= 28 && bmi < 33)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("OVERWEIGHT");
                        }
                        else if (bmi >= 33 && bmi < 38)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("OBESE");
                        }
                        else if (bmi >= 38)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("EXTREMLY OBESE");
                        }

                    }
                    else if (age >= 65)
                    {
                        Console.WriteLine();
                        bmi = kg / (height * height);
                        Console.WriteLine("Ideal BMI for your age: Between 24-29");


                        if (bmi < 24)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("UNDERWEIGHT");
                        }
                        else if (bmi >= 24 && bmi < 29)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("NORMAL");
                        }
                        else if (bmi >= 29 && bmi < 34)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("OVERWEIGHT");
                        }
                        else if (bmi >= 34 && bmi < 39)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("OBESE");
                        }
                        else if (bmi >= 39)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("EXTREMLY OBESE");
                        }

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Although the calculation method of height weight index for 2 to 18 year olds and children is done in the same way, the results are evaluated differently.\n Even if two children have exactly the same BMI, it can be seen that one is obese and the other is at ideal weight.\n In other words, since height and weight index in this age group differs according to age and gender,\n it is recommended that the measurement be made by a specialist dietitian or pediatrician.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR!");
                    Console.WriteLine("YOU ENTERED THE GENDER SECTION WRONG.");
                    Console.WriteLine("LOGGING OUT...");
                    Thread.Sleep(2000);


                }

                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine(" " + person[i] + "\n " + "Age: " + age + "\n" + " Weight: " + kg + "kg\n" + " Height: " + height + "cm\n" + " BMI: " + bmi + "\n");


            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("-------------------- Wish You a Healthy Life --------------------");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
