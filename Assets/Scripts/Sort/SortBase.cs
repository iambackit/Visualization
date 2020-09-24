using Assets.Scripts.Data;
using Assets.Scripts.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace Assets.Scripts.Sort
{
    public abstract class SortBase : MonoBehaviour, ISort
    {
        public static float Time = 1f;
        public static bool IsFinished = true;
        public abstract IEnumerator Sort(GameObject[] objects);

        protected Dictionary<int, int> SetIndicies(GameObject[] objects)
        {
            Dictionary<int, int> indicies = new Dictionary<int, int>();

            int i = 0;
            foreach (GameObject item in objects)
            {
                int idx = item.GetComponent<Circle>().ActualIndex;
                indicies.Add(idx, i);
                i++;
            }

            return indicies;
        }

        protected void SwapPosition(GameObject first, GameObject second)
        {
            Vector2 tmpPosition = first.GetComponent<Circle>().Position;
            first.GetComponent<Circle>().Position = second.GetComponent<Circle>().Position;
            second.GetComponent<Circle>().Position = tmpPosition;
        }

        protected void SwapIndex(GameObject first, GameObject second)
        {
            int tmpValue = first.GetComponent<Circle>().ActualIndex;
            first.GetComponent<Circle>().ActualIndex = second.GetComponent<Circle>().ActualIndex;
            second.GetComponent<Circle>().ActualIndex = tmpValue;
        }

        protected void AddFade(GameObject[] objects)
        {
            foreach (GameObject item in objects)
            {
                Color c = item.GetComponent<Circle>().Color;
                item.GetComponent<Circle>().Color = new Color(c.r, c.g, c.b, .65f);
            }
        }

        protected void RemoveFade(GameObject go)
        {
            Color c = go.GetComponent<Circle>().Color;
            go.GetComponent<Circle>().Color = new Color(c.r, c.g, c.b, 1f);
        }

        protected GameObject GetObjectByActualPosition(GameObject[] objects, int idx)
        {
            foreach (GameObject item in objects)
            {
                if (item.GetComponent<Circle>().ActualIndex == idx)
                    return item;
            }

            return null;
        }
    }
}
