using Assets.Scripts.Data;
using UnityEngine;

namespace Assets.Scripts.Shuffle
{
    public class RandomSort : RandomSortBase
    {
        public override void Shuffle(CircleArray circles)
        {
            base.LoopCount = 1000;
            base.Shuffle(circles);
        }

    }
}