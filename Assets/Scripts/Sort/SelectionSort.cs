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

            //for (int i = 0; i < objects.Length - 1; i++)
            //{
            //    GameObject prev = objects[indicies[i]];
            //    Color savedPrevColor = prev.GetComponent<Circle>().Color;
            //    prev.GetComponent<Circle>().Color = Color.white;

            //    for (int j = i + 1; j < objects.Length; j++)
            //    {
            //        GameObject next = objects[indicies[j]];
            //        Color savedNextColor = next.GetComponent<Circle>().Color;
            //        next.GetComponent<Circle>().Color = Color.white;

            //        int prevPlace = prev.GetComponent<Circle>().Place;
            //        int nextPlace = next.GetComponent<Circle>().Place;

            //        if (indicies[i] > indicies[j])
            //        {
            //            Vector2 tmpPosition = prev.GetComponent<Circle>().Position;
            //            prev.GetComponent<Circle>().Position = next.GetComponent<Circle>().Position;
            //            next.GetComponent<Circle>().Position = tmpPosition;

            //            int tmpPlace = prev.GetComponent<Circle>().Place;
            //            prev.GetComponent<Circle>().Place = next.GetComponent<Circle>().Place;
            //            next.GetComponent<Circle>().Place = tmpPlace;

            //            int tmp = indicies[i];
            //            indicies[i] = indicies[j];
            //            indicies[j] = tmp;
            //        }

                    yield return new WaitForSeconds(Time);
            //        next.GetComponent<Circle>().Color = savedNextColor;
            //    }
            //    prev.GetComponent<Circle>().Color = savedPrevColor;
            //}

            IsFinished = true;
        }
    }
}