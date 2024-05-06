using System.ComponentModel.Design;

namespace Nested_Arrays_Notes
{
    internal class Program
    {
        // 3 levels of variable scope
        // Class Level
        // Method Level
        // Block Level
        static void Main(string[] args)
        {
            // Carla Baysinger
            // Nested Arrays Notes
            // May 5th 2024

            LetterGradeConverter();
            RandomExample();

            //An array is a COLLECTION of variables of the same type
            // Method Scope
            // To declare an array you type[]
            // To initialize = new type[size]
            int[] vickysGrades = new int[10];

            // How to initialize an array with values
            int[] willsGrades = new int[] { 10, 45, 99, 14, 56 };

            //change the value of an element
            int changeGrade = 10;
            vickysGrades[0] = 10;

            // to access an element in the array, you use [index]
            //Element is the term for an individual value an array
            //all arrays start at index 0
            int firstGrade = vickysGrades[0];
            Console.WriteLine(firstGrade);

            Console.WriteLine("Display Wills Grades");
            //i=0 starts at the begining of our array
            //array.length
            //the last index is always.length -1
            //elements: 1, 2, 3, 4, 5, 6
            //values: 10, 45, 99, 14, 56, 87
            //index: 0, 1,2, 3, 4, 5
            Console.WriteLine(willsGrades.Length);
            int totalGrade = 0;
            for (int i = 0; i < willsGrades.Length; i++)
            {
                //storing the current grade
                int willsCurrentGrade = willsGrades[i];
                totalGrade += willsCurrentGrade;
                    int currentElement = i + 1;
                int currentIndex = i;
                Console.WriteLine($"index {currentIndex} : Value{willsCurrentGrade} : Element {currentElement}");
            }
            double averageGrade = Math.Round((double)totalGrade / willsGrades.Length);
            Console.WriteLine($"Wills Average Grade is {averageGrade}");



        }//Main

        public static void RandomExample()
        {
            //Random Object
            //Type Random
            Random rand = new Random();
            //In order to use our random object we call the .Next Method
            int randomNumber = rand.Next();
            //Calling next with a max value (exclusive)
            int randomNumberMaxValue = rand.Next(101);
            // calling next with a min and max value
            int randomNumberMinMax = rand.Next(-50, 51);

            //--- Calling the same seed

            for (int i = 0; i < 10; i++)
            {
                Random rand2 = new Random();
                Console.WriteLine(rand2.Next());
            }

            Console.WriteLine(randomNumberMaxValue);

        }

        public static void LetterGradeConverter()
        {
            //what is a nested if?
            //answers one question
            //If (condition1 && Condition2)
            //If (condition) {
            // If (subsequent conditon) {
            // }
            //Nested Conditions
            //Grading Table
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                int numericalGrade = rand.Next(45, 106);
                // error > 100
                //A - 90-100
                //B - 80-89
                //C - 70-79
                //D - 60-69
                //F - <60
                Console.Write($"{numericalGrade}-");
                string letterGrade = "";
                // | 101 ----------
                if (numericalGrade > 100)
                {
                    letterGrade = "Invalid Input";
                }
                // | 90 ------ A ----- 100
                else if (numericalGrade >= 90)
                {
                    numericalGrade -= 90;
                    letterGrade = "A";

                    if (numericalGrade <= 95)
                    {
                        letterGrade += "-";
                    }

                }
                else if (numericalGrade >= 80)
                {
                    numericalGrade -= 80;
                    letterGrade = "B";

                    if (numericalGrade > 7)
                    {
                        letterGrade += "+";
                    }
                    else if (numericalGrade <= 3)
                    {
                        letterGrade += "-";
                    }
                }
                else if (numericalGrade >= 70)
                {
                    letterGrade = "C";

                    if (numericalGrade > 7)
                    {
                        letterGrade += "+";
                    }
                    else if (numericalGrade <= 3)
                    {
                        letterGrade += "-";
                    }
                }
                else if (numericalGrade >= 60)
                {
                    letterGrade = "D";

                    if (numericalGrade > 7)
                    {
                        letterGrade += "+";
                    }
                    else if (numericalGrade <= 3)
                    {
                        letterGrade += "-";
                    }
                }
                else
                {
                    letterGrade = "F";
                }

                letterGrade = "Grade" + letterGrade;
                Console.WriteLine(letterGrade);
            }
        }

    }//class
}//namespace
