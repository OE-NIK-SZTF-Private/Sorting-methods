using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokminden_egybe
{
    static class Sorting
    {
        #region MinimalSorting
        /// <summary>
        /// Sort a List or an array in ascendant order. Indexing start from zero and tend to run until last index.
        /// (Optional): Sorting can be run at a specific range of indexes.
        /// </summary>
        /// <param name="array">Integer array.</param>
        /// <param name="startOfRange">(Optional) The first index of the range where the sorting will run.</param>
        /// <param name="endOfRange">(Optional) The last index of the range where the sorting will run.</param>
        public static void MinimalSort(int[] array, [Optional, DefaultParameterValue(0)]int startOfRange, [Optional, DefaultParameterValue(0)]int endOfRange)
        {
            if (endOfRange == 0)
            {
                endOfRange = array.Length;
            }
            try
            {
                for (int i = startOfRange; i < endOfRange - 1; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < endOfRange; j++)
                    {
                        if (array[min] > array[j])
                        {
                            min = j;
                        }
                    }
                    int seged = array[i];
                    array[i] = array[min];
                    array[min] = seged;
                }
            }
            catch (IndexOutOfRangeException)
            {
                throw;
            } 
        }

        /// <summary>
        /// Sort a List or an array in ascendant order.
        /// (Optional) Indexing starts from zero. Start and last index included in sorting.
        /// </summary>
        /// <param name="array">Double array.</param>
        /// <param name="startRange">(Optional) The first index of the range where the sorting will run.</param>
        /// <param name="endRange">(Optional) The last index of the range where the sorting will run.</param>
        public static void MinimalSort(double[] array, [Optional, DefaultParameterValue(0)]int startRange, [Optional, DefaultParameterValue(0)]int endRange)
        {
            if (endRange == 0)
            {
                endRange = array.Length;
            }
            try
            {
                for (int i = startRange; i < endRange - 1; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < endRange; j++)
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
            catch (IndexOutOfRangeException)
            {
                throw;
            }
        }

        /// <summary>
        /// Sort a List or an array in ascendant order.
        /// (Optional) Indexing starts from zero. Start and last index included in sorting.
        /// </summary>
        /// <param name="array">Float array.</param>
        /// <param name="startRange">(Optional) The first index of the range where the sorting will run.</param>
        /// <param name="endRange">(Optional) The last index of the range where the sorting will run.</param>
        public static void MinimalSort(float[] array, [Optional, DefaultParameterValue(0)]int startRange, [Optional, DefaultParameterValue(0)]int endRange)
        {
            if (endRange == 0)
            {
                endRange = array.Length;
            }
            try
            {
                for (int i = startRange; i < endRange - 1; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < endRange; j++)
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
            catch (IndexOutOfRangeException)
            {
                throw;
            }
        }

        /// <summary>
        /// Sort a List or an array in ascendant order.
        /// (Optional) Indexing starts from zero. Start and last index included in sorting.
        /// </summary>
        /// <param name="array">Character array.</param>
        /// <param name="startRange">(Optional) The first index of the range where the sorting will run.</param>
        /// <param name="endRange">(Optional) The last index of the range where the sorting will run.</param>
        public static void MinimalSort(char[] array, [Optional, DefaultParameterValue(0)]int startRange, [Optional, DefaultParameterValue(0)]int endRange)
        {
            if (endRange == 0)
            {
                endRange = array.Length;
            }
            try
            {
                for (int i = startRange; i < endRange - 1; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < endRange; j++)
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
            catch (IndexOutOfRangeException)
            {
                throw;
            }
        }

        /// <summary>
        /// Sort a List or an array in ascendant order.
        /// (Optional) Indexing starts from zero. Start and last index included in sorting.
        /// </summary>
        /// <param name="array">Integer List.</param>
        /// <param name="startRange">(Optional) The first index of the range where the sorting will run.</param>
        /// <param name="endRange">(Optional) The last index of the range where the sorting will run.</param>
        public static void MinimalSort(List<int> list, [Optional, DefaultParameterValue(0)]int startRange, [Optional, DefaultParameterValue(0)]int endRange)
        {
            if (endRange == 0)
            {
                endRange = list.Count;
            }
            try
            {
                for (int i = startRange; i < endRange - 1; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < endRange; j++)
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
            catch (IndexOutOfRangeException)
            {
                throw;
            }
        }

        /// <summary>
        /// Sort a List or an array in ascendant order.
        /// (Optional) Indexing starts from zero. Start and last index included in sorting.
        /// </summary>
        /// <param name="array">Double List.</param>
        /// <param name="startRange">(Optional) The first index of the range where the sorting will run.</param>
        /// <param name="endRange">(Optional) The last index of the range where the sorting will run.</param>
        public static void MinimalSort(List<double> list, [Optional, DefaultParameterValue(0)]int startRange, [Optional, DefaultParameterValue(0)]int endRange)
        {
            if (endRange == 0)
            {
                endRange = list.Count;
            }
            try
            {
                for (int i = startRange; i < endRange - 1; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < endRange; j++)
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
            catch (IndexOutOfRangeException)
            {
                throw;
            }
        }

        /// <summary>
        /// Sort a List or an array in ascendant order.
        /// (Optional) Indexing starts from zero. Start and last index included in sorting.
        /// </summary>
        /// <param name="array">Float List.</param>
        /// <param name="startRange">(Optional) The first index of the range where the sorting will run.</param>
        /// <param name="endRange">(Optional) The last index of the range where the sorting will run.</param>
        public static void MinimalSort(List<float> list, [Optional, DefaultParameterValue(0)]int startRange, [Optional, DefaultParameterValue(0)]int endRange)
        {
            if (endRange == 0)
            {
                endRange = list.Count;
            }
            try
            {
                for (int i = startRange; i < endRange - 1; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < endRange; j++)
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
            catch (IndexOutOfRangeException)
            {
                throw;
            }
        }

        /// <summary>
        /// Sort a List or an array in ascendant order.
        /// (Optional) Indexing starts from zero. Start and last index included in sorting.
        /// </summary>
        /// <param name="array">Character List.</param>
        /// <param name="startRange">(Optional) The first index of the range where the sorting will run.</param>
        /// <param name="endRange">(Optional) The last index of the range where the sorting will run.</param>
        public static void MinimalSort(List<char> list, [Optional, DefaultParameterValue(0)]int startRange, [Optional, DefaultParameterValue(0)]int endRange)
        {
            if (endRange == 0)
            {
                endRange = list.Count;
            }
            try
            {
                for (int i = startRange; i < endRange - 1; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < endRange; j++)
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
            catch (IndexOutOfRangeException)
            {
                throw;
            }
        }
        #endregion

        #region BubbelSort

        #endregion
    }
}