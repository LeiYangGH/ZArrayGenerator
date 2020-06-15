﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZArrayGenerator
{
    public class Permutation<T>
    {
        /// <summary>
        /// Permutate an array of items and get a list of the permutated items
        /// </summary>
        /// <param name="n">The lenght of the items to be permutated</param>
        /// <param name="array">The array of items to be permutated</param>
        /// <returns>A list of the different permutated array</returns>
        /// 
        List<T[]> permutated_items = new List<T[]>();
        bool start = true;
        private List<T[]> perm(int n, T[] array)
        {
            if (n == 1)
            {
                // the is where each permutation is added 
                permutated_items.Add(((T[])array.Clone()));
            }

            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    perm(n - 1, array);
                    if (n % 2 == 0)
                    {
                        swap(ref array[i], ref array[n - 1]);
                    }
                    else
                    {
                        swap(ref array[0], ref array[n - 1]);
                    }
                }
                perm(n - 1, array);
            }
            start = false;
            return permutated_items;
        }

        public List<T[]> permutate(T[] array)
        {
            List<T[]> result = perm(array.Length, array);
            permutated_items = new List<T[]>();
            return result;
        }

        /// <summary>
        /// swap two variables
        /// </summary>
        /// <param name="x">the first variable to be swapped</param>
        /// <param name="y">the second variable to be swapped</param>
        private static void swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}
