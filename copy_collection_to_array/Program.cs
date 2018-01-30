/*
 *  C# Program to Copy Collection to Array
 */
using System;
using System.Collections;

namespace copy_collection_to_array
{
    class CopyCollectionToArray
    {

        public static void Main()
        {
            ArrayList list = new ArrayList(5);
            list.Add("BOB");
            list.Add("TOM");
            list.Add("Jerry");
            list.Add("MOB");


            object[] objectArray = list.ToArray();

            string[] stringArray = new string[list.Count];
            list.CopyTo(stringArray, 0);
            string[] typedArray = (string[])list.ToArray(typeof(String));

            Console.Write("Object array:");
            foreach (string str in objectArray)
            { Console.Write(" {0},", str); }
            Console.Write("\nString array:");
            foreach (string str in stringArray)
            { Console.Write(" {0},", str); }
            Console.Write("\nTyped  array:");
            foreach (string str in typedArray)
            { Console.Write(" {0},", str); }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
