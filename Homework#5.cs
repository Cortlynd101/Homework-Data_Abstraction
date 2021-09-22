using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;

namespace AllHW
{
    internal class HomeWorkFive
    {
        public static void ListBuilder(LinkedList<int> ListOne, LinkedList<int> ListTwo, LinkedList<int> ListThree) //This builds the lists that I use for problem #7
        {
            //I am using the built in LinkedList<T> feature of c#.
            ListOne.AddFirst(1);
            ListOne.AddAfter(ListOne.First, 5);
            ListOne.AddAfter(ListOne.First.Next, 8);

            ListTwo.AddFirst(2);
            ListTwo.AddAfter(ListTwo.First, 4);
            ListTwo.AddAfter(ListTwo.First.Next, 9);
        }

        public static void ListCombiner_Decending(LinkedList<int> ListOne, LinkedList<int> ListTwo, LinkedList<int> ListThree) //This is problem #7
        //We take in three LinkedList<int>s and combine the first two in descending order. This assumes that ListOne is alreadu in decending order.
        {
            ListThree = ListOne; //First we make the first(assuming the first is already in descending order) and third list the same thing.
            LinkedListNode<int> ListTwoCurrent = ListTwo.First;
            LinkedListNode<int> ListThreeCurrent = ListThree.First;

            for (int i = 0; i < ListTwo.Count; i++) //We'll check every item on ListTwo and place it.
            {
                
                if (i == 0) //If its the first item, we compare it directly to the other first item.
                {

                    if (ListThree.First.Value < ListTwo.First.Value)
                    {
                        ListThree.AddAfter(ListThree.First, ListTwo.First.Value);
                    }
                    else if (ListThree.First.Value > ListTwo.First.Value)
                    {
                        ListThree.AddBefore(ListThree.First, ListTwo.First.Value);
                    }
                }
                else
                {
                    ListTwoCurrent = ListTwoCurrent.Next; //We need to select the next node of ListTwo to work on

                    for (int j = 0; j < ListThree.Count; j++) //I have it compare to every item on ListThree
                    {
                        if (j == 0) //We have to reset the 'current' for ListThree to be the first again
                        {
                            ListThreeCurrent = ListThree.First;
                        }
                        else //We go to the next through each iteration though.
                        {
                            ListThreeCurrent = ListThreeCurrent.Next;
                        }

                        if (ListThreeCurrent.Value > ListTwoCurrent.Value) 
                        /*
                        If the value in ListThree current is greater than the value in ListTwo,
                        we put the list ListTwo current value before the ListThree current value.
                        */
                        {
                            ListThree.AddBefore(ListThree.Find(ListThreeCurrent.Value), ListTwoCurrent.Value);
                            j = ListThree.Count;
                        }

                        if (j == ListThree.Count - 1) 
                        //If we reach the last iteration then we know the final ListTwo current value must be the largest so we add it to the end
                        {
                            ListThree.AddAfter(ListThree.Find(ListThreeCurrent.Value), ListTwoCurrent.Value);
                            j = ListThree.Count;
                        }
                    }
                }
            }

            for (int i = 0; i < ListThree.Count; i++) //This just iterates through as many times as there are items in ListThree.
            {
                if (i == 0)
                {
                    ListThreeCurrent = ListThree.First;
                }
                else
                {
                    ListThreeCurrent = ListThreeCurrent.Next; 
                }

                //This just prints out the new list in order.
                WriteLine($"\nList #{i + 1}: {ListThreeCurrent.Value.ToString()}");
            }
        }
    }
}