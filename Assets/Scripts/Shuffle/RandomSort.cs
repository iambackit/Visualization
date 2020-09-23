using UnityEngine;

namespace Assets.Scripts.Shuffle
{
    public class RandomSort : RandomSortBase
    {
        public override void Shuffle(GameObject[] circles)
        {
            base.LoopCount = 1000;
            base.Shuffle(circles);
        }

    }
}