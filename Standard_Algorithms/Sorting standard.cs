using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Algorithms
{
    public class Sorting_standard
    {
        /// <summary>
        /// Сортировка пузырькоам
        /// </summary>
        /// <param name="arr"></param>
        public void BubbleSort(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j + 1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// сортировка пузырьком по убыванию
        /// </summary>
        /// <param name="arr"></param>
        public void RevBubbleSort(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Сортировка пузырьком с конца
        /// </summary>
        /// <param name="arr"></param>
        public void BubbleInvSort(ref int[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
       
        /// <summary>
        /// Сортировка пузырьком 
        /// </summary>
        /// <param name="arr"></param>
        public void RevBubbleInvSort(ref int[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public void CocktailSort(ref int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (arr[i] > arr[i+1])
                    {
                        int temp = arr[i+1];
                        arr[i+1]= arr[i];
                        arr[i] = temp;
                    }
                }
                right--;

                for (int i = right; i > left;i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        int temp = arr[i-1];
                        arr[i-1] = arr[i];
                        arr[i] = temp;
                    }
                }
                left++;
            }

        }
    }


}
