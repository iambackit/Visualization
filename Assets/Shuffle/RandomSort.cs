using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Interfaces;

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