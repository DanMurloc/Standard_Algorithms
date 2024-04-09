using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Algorithms
{
    public class Manipulating_An_Array
    {

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
    }
}
