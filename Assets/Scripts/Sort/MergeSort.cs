using Assets.Scripts.Computing;
using Assets.Scripts.Data;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Sort
{
    class MergeSort : SortBase
    {
        public override IEnumerator Sort(CircleArray numbers)
        {
            QuickSort_Recursive(numbers, 0, numbers.Length - 1);
            yield return new WaitForSeconds(Time);
        }
        static public int Partition(CircleArray circles, int left, int right)
        {
            GameObject pivot = Extension.GetObjectByActualPosition(circles, left);
            while (true)
            {
                while (Extension.Compare(pivot, Extension.GetObjectByActualPosition(circles, left)))
                    left++;

                while (Extension.Compare(Extension.GetObjectByActualPosition(circles, right), pivot))
                    right--;

                if (left < right)
                {
                    Extension.Swap(Extension.GetObjectByActualPosition(circles, right),Extension.GetObjectByActualPosition(circles, left));
                }
                else
                {
                    return right;
                }
            }
        }
        static public void QuickSort_Recursive(CircleArray circles, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(circles, left, right);

                if (pivot > 1)
                    QuickSort_Recursive(circles, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort_Recursive(circles, pivot + 1, right);
            }
        }
    }
}
