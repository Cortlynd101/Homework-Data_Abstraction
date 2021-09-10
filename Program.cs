using System;
using static System.Console;
using System.IO;

namespace AllHW
{
    class Program
    {
        static void Main(string[] args)
        {
            // HomeWorkTwo.ProblemFour("TestFile.txt", "to"); //Problem #4
            // HomeWorkTwo.ProblemNinteen(); //Problem #19
            
            WriteLine($"The number is: {HomeWorkThree.ProblemFour(1, 4)}"); //Answer should be 10.
            WriteLine($"The number is: {HomeWorkThree.ProblemFour(2, 4)}"); //Answer should be 9.
            WriteLine($"The number is: {HomeWorkThree.ProblemFour(2, 6)}"); //Answer should be 20.
        }
    }
}