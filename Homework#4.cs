using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;

namespace AllHW
{
    internal class HomeWorkFour
    {
        public static int ExerciseOne(int[] AnyOldArray) //This method returns the Maximum value of an array you enter into the method.
        {
            int Maximum = 0;

            for (int i = 0; i < AnyOldArray.Length - 1; i++)
            {
                Maximum = i;
            }

            return Maximum;
        }

        public static int ExerciseOneALT(int[] AnyOldArray) //This method returns the Maximum value of an array you enter into the method. 
        //This does it in an easier way I think.
        {
            int Maximum = AnyOldArray.Length - 1;
            return Maximum;
        }

        class Bag //This represents exercise #5 from homework #4.
        {

            /*
            I choose to use a c# generics list for this exercise as it is a pre-existing ADT,
            that could live up to the conditions of the Bag type of list that the exercise wants us to use.
            */

            public static void Add(object item, List<object> List) //This will add an item of a certain object type to a list of the matching object type.
            {
                List.Add(item);
                WriteLine($"\nItem {item}, has been added to list {List}. ");
            }

            public static void RemoveLast(List<object> List) //This will remove the last item of a c# generics list of any type.
            {
                List.Remove(List.Count - 1);
                WriteLine($"\nThe last item of {List} has been removed. ");
            }

            public static void RemoveRandom(List<object> List) //This will remove a random item of a c# generics list of any type.
            {
                Random rnd = new Random();
                int randomIndex  = rnd.Next(0, List.Count - 1);
                WriteLine($"\nA random item of {List} is {List[randomIndex]}");
            }

            public static void CheckAmount(List<object> List) //This will check the amount of items in a c# generics list of any type.
            {
                WriteLine($"\nThere are {List.Count} items in {List}. ");
            }

            public static void CheckIfEmpty(List<object> List) //This will determine if a c# generics list of any type is empty or not.
            {
                if (List == null)
                {
                    WriteLine("\nThe list is empty. ");
                }
                else
                {
                    WriteLine("\nThe list is not empty. ");
                }
            }

            public static void Empty(List<object> List) //This will remove all items from a c# generics list of any type.
            {
                List.Clear();
                WriteLine("\nThe list has been emptied. ");
            }

            public static void CheckIfFull(List<object> List) //This will always tell you that the list isn't full because the c# generics lists can always be added to.
            {
                WriteLine("\nThe list should never be full as you can always add more to a generics list. ");
            }
        }
    }
}