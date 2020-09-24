using Assets.Scripts.Data;
using Assets.Scripts.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Sort
{
    class BubbleSort : SortBase
    {
        public override IEnumerator Sort(GameObject[] objects)
        {
            IsFinished = false;

            for (int p = 0; p < objects.Length - 2; p++)
            {
                for (int i = 0; i < objects.Length - 1; i++)
                {
                    GameObject prev = GetObjectByActualPosition(objects, i);
                    GameObject next = GetObjectByActualPosition(objects, i + 1);

                    if (prev.GetComponent<Circle>().OriginalIndex > next.GetComponent<Circle>().OriginalIndex)
                    {
                        this.SwapPosition(prev, next);
                        this.SwapIndex(prev, next);
                    }

                    yield return new WaitForSeconds(Time);
                }
            }

            IsFinished = true;
        }

       
    }
}
