﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TestArea
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.Write("Cate numere doriti sa contina vectorul 1?(0,100): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Cate numere doriti sa contina vectorul 2?(0,100): ");
            int a2 = int.Parse(Console.ReadLine());
            int[] arr = new int[a];
            int[] arr2 = new int[a2];
            int[] arr3 = arr;
            Array.Copy(arr, arr3, arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rnd.Next(0, 100);
            }
            PrintArray(arr);
            Console.WriteLine();
            PrintArray(arr2);
            Console.WriteLine();
            StringBuilder sb = new StringBuilder();
            int b;
            if (a2 > a)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr[i] == arr2[j])
                        {
                            b = arr[i];
                            sb.Append(b + " ");
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr2[i] == arr[j])
                        {
                            b = arr2[i];
                            sb.Append(b + " ");
                            break;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Interesctia:");
            for(int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]);
            }
            Console.WriteLine();
            sb.Clear();
            Console.WriteLine();
            Console.WriteLine("Reuniunea:");
            int c = 0;
            if (a2 > a)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                    while (c < arr2.Length)
                    {
                        Console.Write(arr2[c] + " ");
                        c++;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.Write(arr2[i] + " ");
                    while (c < arr.Length)
                    {
                        Console.Write(arr[c] + " ");
                        c++;
                        break;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Diferenta v1-v2");
            if (a2 > a)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr[i] == arr2[j])
                        {
                            arr = arr.Where((source, index) => index != i).ToArray();
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr2[i] == arr[j])
                        {
                            arr = arr.Where((source, index) => index != i).ToArray();
                        }
                    }
                }
            }
            PrintArray(arr);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Diferenta v2-v1");
            if (a > a2)
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    for (int j = 0; j < arr3.Length; j++)
                    {
                        if (arr2[i] == arr3[j])
                        {
                            arr2 = arr2.Where((source, index) => index != i).ToArray();

                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr3.Length; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr3[i] == arr2[j])
                        {
                            arr2 = arr2.Where((source, index) => index != i).ToArray();

                        }
                    }
                }
            }
            PrintArray(arr2);
            Console.WriteLine();
            Console.WriteLine();
        }
        private static void Swap(int[] arr, int i, int j)
        {
            int aux;
            aux = arr[i];
            arr[i] = arr[j];
            arr[j] = aux;
        }
        public static void PrintArray(int[] arr)
        {
            Console.Write("Vectorul: ");
            for (int i = 0; i<arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
        public static int[] GenerateArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 50);
            }
            return arr;
        }
    }
} 