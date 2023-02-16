/* Kyle Kettles
 * 02/16/23
 * Method 1: Randomly populate an array with integers numbers between 10 and 50. The array length is a parameter for the method. 
 Ask the user to enter an integer number between 5 and 15.
 Use a try/catch block to validate the user’s entry.
 Use a conditional statement to check the user’s entry is between 5 and 15.
 Use Method 1 to randomly populates an array with a length equal to the user’s input.
 Display in the console all the elements the in the array.
 Use Method 2 to sum all the elements in the array from step 4.
 Display in the console the value from step 6.
*/

using System;
using System.Linq.Expressions;
using System.Net.Security;

namespace deliverable5_methods
{
    internal class Program
    {
       
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }
            return MyArray;

        }
        
        static int sum(int[] array)
        {
            int sum = 0;
            foreach(int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter an integer between 5 and 15");
            try
            {
                int input = int.Parse(Console.ReadLine());
                if (input <= 15 && input >= 5)

                {
                    int[] sampleArray = random_array(input);

                    Console.WriteLine(" ");
                    Console.WriteLine("The elements in the random array are: ");
                    foreach (int element in sampleArray)
                    {
                        Console.Write(element + " ");
                    }
                    Console.WriteLine("The sum is: " + sum(sampleArray));
                }
                else
                {
                    Console.WriteLine("Enter an integer between 5 and 15");
                    System.Environment.Exit(0);
                }
            }
            catch
            {
            }

        }
        
    }
}