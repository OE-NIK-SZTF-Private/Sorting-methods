using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokminden_egybe
{
    static class Sorting
    {
        public static void MinimalSort(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[min]>array[j])
                    {
                        min = j;
                    }
                }
                int seged = array[i];
                array[i] = array[min];
                array[min] = seged;
            }
        }

        public static void MinimalSort(float[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[min] > array[j])
                    {
                        min = j;
                    }
                }
                float seged = array[i];
                array[i] = array[min];
                array[min] = seged;
            }
        }

        public static void MinimalSort(double[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[min] > array[j])
                    {
                        min = j;
                    }
                }
                double seged = array[i];
                array[i] = array[min];
                array[min] = seged;
            }
        }

        public static void MinimalSort(char[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[min] > array[j])
                    {
                        min = j;
                    }
                }
                char seged = array[i];
                array[i] = array[min];
                array[min] = seged;
            }
        }

        public static void MinimalSort(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[min] > list[j])
                    {
                        min = j;
                    }
                }
                int seged = list[i];
                list[i] = list[min];
                list[min] = seged;
            }
        }

        public static void MinimalSort(List<float> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[min] > list[j])
                    {
                        min = j;
                    }
                }
                float seged = list[i];
                list[i] = list[min];
                list[min] = seged;
            }
        }

        public static void MinimalSort(List<double> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[min] > list[j])
                    {
                        min = j;
                    }
                }
                double seged = list[i];
                list[i] = list[min];
                list[min] = seged;
            }
        }

        public static void MinimalSort(List<char> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[min] > list[j])
                    {
                        min = j;
                    }
                }
                char seged = list[i];
                list[i] = list[min];
                list[min] = seged;
            }
        }
    }
}
