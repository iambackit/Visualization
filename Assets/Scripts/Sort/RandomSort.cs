using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Interfaces;

namespace Assets.Scripts.Sort
{
    public class RandomSort : RandomSortBase
    {
        public new void Sort(GameObject[] circles)
        {
            base.LoopCount = 1000;
            base.Sort(circles);
        }

    }
}