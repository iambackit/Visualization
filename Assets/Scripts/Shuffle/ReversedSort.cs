using Assets.Scripts.Interfaces;
using Assets.Scripts.Data;
using UnityEngine;

namespace Assets.Scripts.Shuffle
{
    public class ReversedSort : IShuffle
    {
        public virtual void Shuffle(GameObject[] circles)
        {
            int r0, r1;

            for (int i = 0; i < circles.Length / 2; i++)
            {
                r0 = i;
                r1 = circles.Length - 1 - i;

                Vector2 r0Position = circles[r0].GetComponent<Circle>().Position;
                circles[r0].GetComponent<Circle>().Position = circles[r1].GetComponent<Circle>().Position;
                circles[r1].GetComponent<Circle>().Position = r0Position;

                int r0Place = circles[r0].GetComponent<Circle>().Value;
                circles[r0].GetComponent<Circle>().Value = circles[r1].GetComponent<Circle>().Value;
                circles[r1].GetComponent<Circle>().Value = r0Place;
            }
        }
    }
}