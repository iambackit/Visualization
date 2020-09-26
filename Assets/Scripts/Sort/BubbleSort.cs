using Assets.Scripts.Computing;
using Assets.Scripts.Data;
using Assets.Scripts.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Sort
{
    class BubbleSort : SortBase
    {
        public override IEnumerator Sort(CircleArray objects)
        {
            IsFinished = false;
            int tmpIdx = objects.Length - 1;

            for (int p = 0; p < objects.Length - 2; p++)
            {
                for (int i = 0; i < objects.Length - 1; i++)
                {
                    GameObject prev = Extension.GetObjectByActualPosition(objects, i);
                    GameObject next = Extension.GetObjectByActualPosition(objects, i + 1);

                    if (Extension.Compare(prev, next))
                    {
                        Extension.Swap(prev, next);
                    }

                    yield return new WaitForSeconds(Time);
                }

                tmpIdx--;
            }

            IsFinished = true;
        }

       
    }
}
