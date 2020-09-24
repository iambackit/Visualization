using Assets.Scripts.Data;
using System;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Computing
{
    public static class Extension
    {
        public static T Next<T>(this T v) where T : struct
        {
            return Enum.GetValues(v.GetType()).Cast<T>().Concat(new[] { default(T) }).SkipWhile(e => !v.Equals(e)).Skip(1).First();
        }

        public static T Previous<T>(this T v) where T : struct
        {
            return Enum.GetValues(v.GetType()).Cast<T>().Concat(new[] { default(T) }).Reverse().SkipWhile(e => !v.Equals(e)).Skip(1).First();
        }

        //return true if a is bigger than b
        public static bool Compare(GameObject a, GameObject b)
        {
            int aOriginalPosition = a.GetComponent<Circle>().OriginalIndex;
            int bOriginalPosition = b.GetComponent<Circle>().OriginalIndex;

            return aOriginalPosition > bOriginalPosition;
        }

        public static void Swap(GameObject a, GameObject b)
        {
            Vector2 tmpPosition = a.GetComponent<Circle>().Position;
            a.GetComponent<Circle>().Position = b.GetComponent<Circle>().Position;
            b.GetComponent<Circle>().Position = tmpPosition;

            int tmpValue = a.GetComponent<Circle>().ActualIndex;
            a.GetComponent<Circle>().ActualIndex = b.GetComponent<Circle>().ActualIndex;
            b.GetComponent<Circle>().ActualIndex = tmpValue;
        }

        public static GameObject GetObjectByActualPosition(GameObject[] objects, int idx)
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