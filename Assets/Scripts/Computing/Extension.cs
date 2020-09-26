using Assets.Scripts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Assets.Scripts.Computing
{
    public static class Extension
    {
        public static int CircleCount { get; set; }
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
            Circle aCircle = a.GetComponent<Circle>();
            Circle bCircle = b.GetComponent<Circle>();

            Vector2 tmpPosition = aCircle.Position;
            aCircle.Position = bCircle.Position;
            bCircle.Position = tmpPosition;

            int tmpValue = aCircle.ActualIndex;
            aCircle.ActualIndex = bCircle.ActualIndex;
            bCircle.ActualIndex = tmpValue;

            CalculateSizeBasedOnPosition(a, aCircle);
            CalculateSizeBasedOnPosition(b, bCircle);
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
            Circle circle = go.GetComponent<Circle>();
            Color c = circle.Color;
            circle.Color = new Color(c.r, c.g, c.b, 1f);
        }

        private static void CalculateSizeBasedOnPosition(GameObject go, Circle circle)
        {
            int relativeMaxDiff = Mathf.Max(Math.Abs(circle.OriginalIndex - 0), Math.Abs(circle.OriginalIndex - (CircleCount - 1)));
            int diff = Math.Abs(circle.OriginalIndex - circle.ActualIndex);
            float relativeDiff = (float)diff / relativeMaxDiff;
            relativeDiff = 1 - relativeDiff;
            go.transform.localScale = new Vector2(1 * relativeDiff, 1 * relativeDiff);
        }
    }
}