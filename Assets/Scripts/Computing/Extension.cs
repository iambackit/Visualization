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

        public static GameObject GetObjectByActualPosition(CircleArray objects, int idx)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                if (objects[i].GetComponent<Circle>().ActualIndex == idx)
                    return objects[i];
            }

            return null;
        }

        public static void AddFade(CircleArray objects)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                Color c = objects[i].GetComponent<Circle>().Color;
                objects[i].GetComponent<Circle>().Color = new Color(c.r, c.g, c.b, .65f);
            }
        }

        public static void RemoveFade(GameObject go)
        {
            Color c = go.GetComponent<Circle>().Color;
            go.GetComponent<Circle>().Color = new Color(c.r, c.g, c.b, 1f);
        }
    }
}