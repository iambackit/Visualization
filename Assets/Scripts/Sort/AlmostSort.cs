using UnityEngine;
using Assets.Scripts.Interfaces;

namespace Assets.Scripts.Sort
{
    class AlmostSort : RandomSortBase
    {
        public void Sort(GameObject[] circles)
        {
            base.LoopCount = 10;
            base.Sort(circles);
        }
    }
}
