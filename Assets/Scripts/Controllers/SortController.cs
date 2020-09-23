using Assets.Scripts.Shuffle;
using Assets.Scripts.Sort;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    class SortController
    {
        public SortController()
        {
            this._linearSort = new LinearSort();
            this._bubbleSort = new BubbleSort();
        }

        public void Sort(GameObject[] objects, Enums.Algorithm selectedSorting)
        {
            switch (selectedSorting)
            {
                case Enums.Algorithm.Linear:
                    this._linearSort.Sort(objects);
                    break;
                case Enums.Algorithm.Bubble:
                    this._bubbleSort.Sort(objects);
                    break;
                default:
                    break;
            }
        }

        private LinearSort _linearSort;
        private BubbleSort _bubbleSort;
    }
}
