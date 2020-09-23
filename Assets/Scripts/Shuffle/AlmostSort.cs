using UnityEngine;
using Assets.Scripts.Interfaces;

namespace Assets.Scripts.Shuffle
{
    class AlmostSort : RandomSortBase
    {
        public override void Shuffle(GameObject[] circles)
        {
            base.LoopCount = 10;
            base.Shuffle(circles);
        }
    }
}
