using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Array'dəki ən kiçik elementi tapıb ekrana yazdırın.

            //int[] arr = { 6, 9, 4, 13, 5, 15, 7, 8 };
            //int result = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < result)
            //    {
            //        result = arr[i];
            //    }
            //}
            //Console.WriteLine(result);



            // 2. Array'in içərisindəki sözləri tərsinə çevirən bir alqoritm yazın.

            //string[] strings = { "test", "product", "cards" };

            //for (int i = 0; i < strings.Length; i++)
            //{
            //    for (int j = strings[i].Length-1; j >= 0; j--)
            //    {
            //        Console.Write(strings[i][j]);

            //    }
            //    Console.WriteLine();
            //}


            // 3. Array'in içərisindəki sözlərin sırasını tərsinə çevirən bir alqoritm yazın.

            //string[] strings = { "test", "product", "cards" };

            //for (int i = strings.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(strings[i]);
            //}



            // 4. Verilmiş integer array-in  bütün elementlərini müsbətə çevirib yeni bir array'ə tərsinə yığın və ekrana
            // çap edin. Məsələn, {-2,3,4,-5} verilibsə, {5,4,3,2} almalıyıq cavab olaraq.

            //int[] arr = { 6, -9, 4, -13, 5 };
            //int[] newArr = new int[5];

            //for (int i = arr.Length-1; i >= 0; i--)
            //{
            //    if (arr[i] < 0)
            //    {
            //        arr[i] = -arr[i];
            //    }
            //    newArr[i] = arr[i];
            //    Console.WriteLine(newArr[i]);
            //}



            // 5. Verilmiş integer array-in  bütün elementlərini stringə çevirib ekrana çap edin.
            // Məsələn, {-2,3,4,-5} verilibsə, "-2 3 4 -5" çapa verilməlidir. (optional)

            int[] arr = { 6, 9, 4, 13, 5 };
            string[] strings = new string[5];
            for (int i = 0; i < arr.Length; i++)
            {
                strings[i] = arr[i].ToString();
                Console.WriteLine(strings[i]);
            }
        }
    }
}
