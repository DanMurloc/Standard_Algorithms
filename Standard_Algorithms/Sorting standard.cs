using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                for (int j = 0; j < arr.Length - i - 1; j++)
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

        /// <summary>
        /// Шейкер сортировка
        /// </summary>
        /// <param name="arr"></param>
        public void CocktailSort(ref int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        int temp = arr[i - 1];
                        arr[i - 1] = arr[i];
                        arr[i] = temp;
                    }
                }
                left++;
            }

        }

        /// <summary>
        /// Шейкер сортировка по убыванию
        /// </summary>
        /// <param name="arr"></param>
        public void RevCocktailSort(ref int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                    }
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (arr[i] > arr[i - 1])
                    {
                        (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]);
                    }
                }
                left++;
            }
        }

        /// <summary>
        /// Сортировка йог-сарона
        /// </summary>
        /// <param name="arr"></param>
        public void BogoSort(ref int[] arr)
        {
            bool chek = true;
            Random random = new Random();
            while (chek)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        chek = true;
                        Random.Shared.Shuffle(arr);
                        break;
                    }
                    if (arr[i] < arr[i + 1])
                    {
                        chek = false;
                    }
                }

            }

        }
        /// <summary>
        /// Сортировка Сталиным
        /// </summary>
        /// <param name="arr"></param>
        public void StalinSort(ref int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    Manipulating_An_Array m = new Manipulating_An_Array();
                    m.RemoveAt(ref arr, i + 1);
                    i--;
                }
            }
        }

        public void ThanosSort(ref int[] arr)
        {
            bool chekSort=true;
            bool chekSort1=true;
            bool chekSort2=true;
            while(chekSort)
            {
                List<int> arr1 = new List<int>();
                List<int> arr2 = new List<int>();
                for (int i = 0; i < arr.Length / 2; i++)
                {
                    arr1.Add(arr[i]);
                }
                for (int i = arr.Length / 2; i < arr.Length; i++)
                {
                    arr2.Add(arr[i]);
                }

                for (int i = 0; i < arr1.Count-1; i++)
                {
                    if (arr1[i] < arr1[i+1])
                    {
                        chekSort1 = true;
                    }
                    else  if (arr1[i] > arr1[i + 1])
                    {
                        chekSort1 = false;
                        break;
                    }
                }
                for (int i = 0; i < arr2.Count - 1; i++)
                {
                    if (arr2[i] < arr2[i + 1])
                    {
                        chekSort2 = true;
                    }
                    else if (arr2[i] > arr2[i + 1])
                    {
                        chekSort2 = false;
                        break;
                    }
                }
                if (chekSort1 && chekSort2)
                {
                    Random r = new Random();
                    int rInt = r.Next(0, 2);
                    if (rInt > 1)
                    {
                        arr = arr1.ToArray();
                    }
                    else
                    {
                        arr = arr2.ToArray();
                    }

                    chekSort = false;
                    break;
                }
                else if (chekSort1)
                {
                    arr = arr1.ToArray();
                    chekSort = false;
                    break;
                }
                else if (chekSort2)
                {
                    arr = arr2.ToArray();
                    chekSort = false;
                    break;
                }


                Random r2 = new Random();
                int rInt2 = r2.Next(0, 2);
                if (rInt2 > 1)
                {
                    arr = arr1.ToArray();
                }
                else
                {
                    arr = arr2.ToArray();
                }

                arr1.Clear();
                arr2.Clear();

            }

        }
    }


}
