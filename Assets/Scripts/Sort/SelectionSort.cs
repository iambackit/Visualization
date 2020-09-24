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
            Dictionary<int, int> indicies = this.SetIndicies(objects);

            for (int i = 0; i < objects.Length - 1; i++)
            {
                int smallestIdx = indicies[i];

                for (int j = i + 1; j < objects.Length; j++)
                {
                    if (indicies[i] > indicies[j])
                    {
                        smallestIdx = j;
                    }

                    yield return new WaitForSeconds(Time);
                }

                Vector2 tmpPosition = objects[indicies[i]].GetComponent<Circle>().Position;
                objects[indicies[i]].GetComponent<Circle>().Position = objects[indicies[smallestIdx]].GetComponent<Circle>().Position;
                objects[indicies[smallestIdx]].GetComponent<Circle>().Position = tmpPosition;

                int tmpPlace = objects[indicies[i]].GetComponent<Circle>().Value;
                objects[indicies[i]].GetComponent<Circle>().Value = objects[indicies[smallestIdx]].GetComponent<Circle>().Value;
                objects[indicies[smallestIdx]].GetComponent<Circle>().Value = tmpPlace;

                int tmp = indicies[i];
                indicies[i] = indicies[smallestIdx];
                indicies[smallestIdx] = tmp;
            }

            IsFinished = true;
        }
    }
}