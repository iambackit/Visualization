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
            Dictionary<int, int> indicies = this.SetIndicies(objects);

            for (int p = 0; p < objects.Length - 2; p++)
            {
                for (int i = 0; i < objects.Length - 1; i++)
                {
                    GameObject prev = objects[indicies[i]];
                    GameObject next = objects[indicies[i + 1]];
                    Color savedPrevColor = prev.GetComponent<Circle>().Color;
                    Color savedNextColor = next.GetComponent<Circle>().Color;
                    prev.GetComponent<Circle>().Color = Color.white;
                    next.GetComponent<Circle>().Color = Color.white;

                    if (indicies[i] > indicies[i + 1])
                    {
                        Vector2 tmpPosition = prev.GetComponent<Circle>().Position;
                        prev.GetComponent<Circle>().Position = next.GetComponent<Circle>().Position;
                        next.GetComponent<Circle>().Position = tmpPosition;

                        int tmpPlace = prev.GetComponent<Circle>().Place;
                        prev.GetComponent<Circle>().Place = next.GetComponent<Circle>().Place;
                        next.GetComponent<Circle>().Place = tmpPlace;

                        int tmp = indicies[i];
                        indicies[i] = indicies[i + 1];
                        indicies[i + 1] = tmp;
                    }

                    yield return new WaitForSeconds(Time);
                    prev.GetComponent<Circle>().Color = savedPrevColor;
                    next.GetComponent<Circle>().Color = savedNextColor;
                }
            }

            IsFinished = true;
        }

       
    }
}
