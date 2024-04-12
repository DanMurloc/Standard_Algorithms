using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Algorithms
{
    public class Manipulating_An_Array
    {

        /// <summary>
        /// Удаление элемента по индексу
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Arr"></param>
        /// <param name="ind"></param>
        public void RemoveAt<T>(ref T[] Arr, int ind)
        {
            T[] arr = new T[Arr.Length - 1];

            for (int i = 0; i < ind; i++)
            {
                arr[i] = Arr[i];
            }
            int k = ind;
            for (int i = ind; i < arr.Length; i++)
            {
                arr[i] = Arr[i + 1];
            }
            Arr = arr;
        }
        
        public void RemoveFirst<T>(ref T[] Arr)
        {
            RemoveAt<T>(ref Arr, 0);
        }

        public void RemoveEnd<T>(ref T[] Arr)
        {
            RemoveAt<T>(ref Arr, Arr.Length-1);
        }

        //Удаление всех элементов перед заданным индексом
        public void RemoveAllFromIndexBack<T>(ref T[] Arr, int ind)
        {
            T[] newArr = new T[Arr.Length - ind];

            for (int i = ind; i < Arr.Length; i++)
            {
                newArr[i - ind] = Arr[i];
            }
            Arr = newArr;
        }

        //Удаление всех элементов после заданного индекса
        public void RemoveAllFromIndexForward<T>(ref T[] Arr, int ind)
        {
            T[] newArr = new T[ind-1];

            for (int i = 0; i < ind-1; i++)
            {
                newArr[i] = Arr[i];
            }
            Arr = newArr;
        }

        //Поворот массива
        public void ReverArray<T>(ref T[] Arr)
        {
            T[] newArr = new T[Arr.Length];
            int k = 0;
            for (int i = Arr.Length-1; i >=0; i--)
            {
                newArr[k] = Arr[i];
                k++;
            }
            Arr = newArr;
        }

    }
}
