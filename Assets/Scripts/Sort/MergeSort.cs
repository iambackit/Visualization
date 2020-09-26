using Assets.Scripts.Computing;
using Assets.Scripts.Data;
using System.Collections;
using UnityEngine;
using System.Collections.Generic;

namespace Assets.Scripts.Sort
{
    class MergeSort : SortBase
    {
        public override IEnumerator Sort(CircleArray circles)
        {
            IsFinished = false;

            QuickSort_Recursive(circles, 0, circles.Length - 1);
            yield return new WaitForSeconds(0);

            IsFinished = true;
        }
        private int Partition(CircleArray circles, int left, int right)
        {
            GameObject pivotGameObject = Extension.GetObjectByActualPosition(circles, left);
            for(;;)
            {
                while (Extension.Compare(pivotGameObject, Extension.GetObjectByActualPosition(circles, left)))
                    left++;

                while (Extension.Compare(Extension.GetObjectByActualPosition(circles, right), pivotGameObject))
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
        private void QuickSort_Recursive(CircleArray circles, int left, int right)
        {
            if (left < right)
            {
                StartCoroutine(Coroutine(circles, left, right));
            }
        }

        private IEnumerator Coroutine(CircleArray circles, int left, int right)
        {
            yield return new WaitForSeconds(Time);
            int pivot = Partition(circles, left, right);

            if (pivot > 1)
                QuickSort_Recursive(circles, left, pivot - 1);

            if (pivot + 1 < right)
                QuickSort_Recursive(circles, pivot + 1, right);
        }
    }
}
