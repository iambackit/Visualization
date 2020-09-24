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
                int idx = item.GetComponent<Circle>().Place;
                indicies.Add(idx, i);
                i++;
            }

            return indicies;
        }
    }
}
