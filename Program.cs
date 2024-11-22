using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
        internal class Program
        {

            static void Main(string[] args)
            {
            int i = 10;
            ArrayList arraylist = new ArrayList();
            Console.WriteLine("Initial Capacity:" + arraylist.Capacity);
            arraylist.Add('1');
            arraylist.Add('B');
            arraylist.Add(4);
            arraylist.Add("C#");
            arraylist.Add("on");
            arraylist.Add(true);
            arraylist.Add(2.7f);
            arraylist.Add("T");
            for (int i = 0; i < 3; i++)
            {
                arraylist.Add("Sumi and Sanjai merge conflict try");
            }

            PrintList(arraylist);

            ////bool containItem = arraylist.Contains('T');
            ////Console.WriteLine(containItem);

            ////arraylist.Remove("C#");
            ////PrintList(arraylist);

            ////arraylist.RemoveAt(0);
            ////PrintList(arraylist);

            ////arraylist.RemoveRange(0, 2);
            ////PrintList(arraylist);

            //arraylist.Insert(8, "O");
            //PrintList(arraylist);

            //int indexof = arraylist.IndexOf("on");
            //Console.WriteLine(indexof);

            //arraylist.Reverse();
            //PrintList(arraylist);


            //Console.WriteLine("Total number of elements:" + arraylist.Count);
            //Console.WriteLine("Capacity:" + arraylist.Capacity);


            //arraylist.InsertRange(1, new string[] { "B", "C#" });
            //Console.WriteLine("\nAfter InsertRange:");
            //PrintList(arraylist);

            //arraylist.AddRange(new int[] { 1, 2, 3 });
            //Console.WriteLine("\nAfter AddRange:");
            //PrintList(arraylist);
            //Console.WriteLine("Capacity:" + arraylist.Capacity);

            ////arraylist.Clear();
            ////Console.WriteLine("After Removing all items:" +arraylist.Count);
            ////PrintList(arraylist);
            //    LinkedList <int> list = new LinkedList<int>();





            Console.ReadKey();
        }



        static void PrintList(ArrayList arraylist)
        {
            foreach (var item in arraylist)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

}
