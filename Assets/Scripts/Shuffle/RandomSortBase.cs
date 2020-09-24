using UnityEngine;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Data;
using Assets.Scripts.Computing;

namespace Assets.Scripts.Shuffle
{
    public class RandomSortBase : IShuffle
    {
        public virtual void Shuffle(GameObject[] circles)
        {
            int r0, r1;

            for (int i = 0; i < LoopCount; i++)
            {
                r0 = Random.Range(0, circles.Length - 1);
                r1 = Random.Range(0, circles.Length - 1);

                Extension.Swap(circles[r0], circles[r1]);
            }
        }

        protected int LoopCount { get; set; }
    }
}