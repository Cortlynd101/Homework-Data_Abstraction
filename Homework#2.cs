using System;
using static System.Console;
using System.IO;

namespace AllHW
{
    public class HomeWorkTwo
    {
        public static void ProblemNinteen()
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

        public static void ProblemFour(string FileName, string WordToBeCounted)
        {
            //Problem #4
            int WordCount = 0;
            try //This try catch makes sure that the program doesn't blow up if the file they gave doesn't exist or is null
            {
                using (StreamReader streamReader = new StreamReader(FileName)) //I decided to use a StreamReader to accomplish this task as I think its a great tool.
                {
                    string allLines = streamReader.ReadToEnd(); //This turns all the lines into one long string basically.
                    string[] lines = allLines.Split(Environment.NewLine); //This splits all of those lines again by where the computer recognizes line splits.

                    foreach (string line in lines) //This runs for each line individually, covering the whole file.
                    {
                        string[] CharsNotAllowed = new string[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "=", "_", "+", @"r", @"rn",
                        "`", "~", "[", "]", "{", "}", ";", "'", ":", ",", ".", "/", "<", ">", "?", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")"};
                        for (int i = 0; i < CharsNotAllowed.Length; i++) //This should replace all of the 'special characters' 
                        {
                            line.Replace(CharsNotAllowed[i], " ");
                        }

                        string[] wordsArray = line.Split(" "); //This splits the line into an array of individual words.
                        for (int i = 0; i < wordsArray.Length; i++)
                        {
                            if (wordsArray[i] == WordToBeCounted)
                            {
                                WordCount++;    //Every time the array member equals the WordToBeCounted, it adds one to WordCount.
                            }
                        }
                    }
                }
            }
            catch //If something was wrong with the file it just tells the user "The file could not be read."
            {
                WriteLine("The file could not be read.");
            }

            WriteLine($"The word '{WordToBeCounted}' appeared '{WordCount}' times in that text file. "); //We let the user know how many times the word appeared.
        }
    }
}
