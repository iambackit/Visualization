using Assets.Scripts.Interfaces;
using Assets.Scripts.Data;
using Assets.Scripts.Computing;
using UnityEngine;

namespace Assets.Scripts.Shuffle
{
    public class ReversedSort : IShuffle
    {
        public virtual void Shuffle(CircleArray circles)
        {
            int r0, r1;

            for (int i = 0; i < circles.Length / 2; i++)
            {
                r0 = i;
                r1 = circles.Length - 1 - i;

                Extension.Swap(circles[r0], circles[r1]);
            }
        }
    }
}