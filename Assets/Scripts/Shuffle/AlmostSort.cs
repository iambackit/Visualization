using UnityEngine;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Data;

namespace Assets.Scripts.Shuffle
{
    class AlmostSort : RandomSortBase
    {
        public override void Shuffle(CircleArray circles)
        {
            base.LoopCount = 10;
            base.Shuffle(circles);
        }
    }
}
