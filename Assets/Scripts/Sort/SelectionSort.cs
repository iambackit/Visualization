using UnityEngine;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Data;
using System.Collections;
using UnityEngine.UIElements;
using System.Collections.Generic;

namespace Assets.Scripts.Sort
{
    public class SelectionSort : SortBase
    {
        public override IEnumerator Sort(GameObject[] objects)
        {
            IsFinished = false;

            for (int i = 0; i < objects.Length - 1; i++)
            {
                GameObject act = GetObjectByActualPosition(objects, i);
                GameObject min = GetObjectByActualPosition(objects, i);
                int minIdx = i;

                for (int j = i + 1; j < objects.Length; j++)
                {
                    GameObject next = GetObjectByActualPosition(objects, j);

                    if (min.GetComponent<Circle>().OriginalIndex > next.GetComponent<Circle>().OriginalIndex)
                    {
                        min = GetObjectByActualPosition(objects, j);
                        minIdx = j;
                    }
                }

                this.SwapPosition(act, min);
                this.SwapIndex(act, min);
                yield return new WaitForSeconds(Time);
            }

            IsFinished = true;
        }
    }
}