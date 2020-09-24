using UnityEngine;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Data;
using System.Collections;
using UnityEngine.UIElements;
using System.Collections.Generic;
using Assets.Scripts.Computing;

namespace Assets.Scripts.Sort
{
    public class SelectionSort : SortBase
    {
        public override IEnumerator Sort(CircleArray objects)
        {
            IsFinished = false;
            Extension.AddFade(objects);

            int smallest;
            for (int i = 0; i < objects.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < objects.Length; j++)
                {
                    if (Extension.Compare(Extension.GetObjectByActualPosition(objects, smallest), Extension.GetObjectByActualPosition(objects, j)))
                    {
                        smallest = j;
                    }
                    yield return new WaitForSeconds(Time);
                }
                Extension.Swap(Extension.GetObjectByActualPosition(objects, smallest), Extension.GetObjectByActualPosition(objects, i));
                Extension.RemoveFade(Extension.GetObjectByActualPosition(objects, i));
            }

            IsFinished = true;
        }
    }
}