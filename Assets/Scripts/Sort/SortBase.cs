using Assets.Scripts.Data;
using Assets.Scripts.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
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
                int idx = item.GetComponent<Circle>().Value;
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

        protected void SwapValue(GameObject first, GameObject second)
        {
            int tmpValue = first.GetComponent<Circle>().Value;
            first.GetComponent<Circle>().Value = second.GetComponent<Circle>().Value;
            second.GetComponent<Circle>().Value = tmpValue;
        }

        protected void SwapIndex(Dictionary<int, int> dictionary, int firstIdx, int secondIdx)
        {
            int tmp = dictionary[firstIdx];
            dictionary[firstIdx] = dictionary[secondIdx];
            dictionary[secondIdx] = tmp;
        }
    }
}
