using UnityEngine;

namespace Assets.Scripts.Shuffle
{
    public class RandomSort : RandomSortBase
    {
        public override void Sort(GameObject[] circles)
        {
            base.LoopCount = 1000;
            base.Sort(circles);
        }

    }
}