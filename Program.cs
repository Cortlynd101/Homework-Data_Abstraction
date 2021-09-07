using System;
using static System.Console;
using System.IO;

namespace HWChapTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader("TestFile.txt", "to"); //Problem #4
            ProblemNinteen(); //Problem #19
        }

        private static void ProblemNinteen()
        {
            Write("What is your age: ");

            bool AgeLearned = false; //Once we determine the users age this bool will be true and we will pass.
            int userAge;
            do
            {
                string userInput = ReadLine();
                try //This try catch assures they do in fact enter a integer for their age.
                {
                    userAge = Int32.Parse(userInput);

                    if (userAge < 0) //If they enter a number less than zero it won't pass. Per specification of problem #19.
                    {
                        WriteLine("That is not a possible age.");
                        Write("Please enter your correct age: ");
                    }
                    else if (userAge >= 122) //If they enter 122 or more it won't pass. Per specification of problem #19.
                    {
                        WriteLine("That is not a possible age.");
                        Write("Please enter your correct age: ");
                    }
                    else
                    { //If they don't enter an integer then it won't let them pass and they'll have to re-enter.
                        AgeLearned = true;
                    }
                }
                catch
                {
                    Write("Please enter a correct input: ");
                }
            } while (AgeLearned == false); //This loop will continue until we get the user age.

            WriteLine("We have gained the users age.");
        }

        public static void StreamReader(string FileName, string WordToBeCounted)
        {
            //Problem #4
            int WordCount = 0;
            try
            {
                using (StreamReader streamReader = new StreamReader(FileName))
                {
                    string line = streamReader.ReadLine();
                    if (line.Contains(WordToBeCounted))
                    {
                        while (line != null | streamReader.EndOfStream == false)
                        {
                            string[] CharsNotAllowed = new string[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "=", "_", "+",
                            "`", "~", "[", "]", "{", "}", ";", "'", ":", ",", ".", "/", "<", ">", "?", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")"};
                            for (int i = 0; i < CharsNotAllowed.Length; i++)
                            {
                                line.Replace(CharsNotAllowed[i], " ");
                                WriteLine("YEEES YEEES");
                            }

                            string[] lineArray = line.Split(" ");
                            for (int i = 0; i < lineArray.Length; i++)
                            {
                                WriteLine("YEEES YEEES YEEES");
                                if (lineArray[i] == WordToBeCounted)
                                {
                                    WordCount++;
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                WriteLine("The file could not be read:");
            }

            WriteLine($"The word {WordToBeCounted} appeared {WordCount} times in that text file. ");
        }
    }
}