using Assets.Scripts.Shuffle;
using Assets.Scripts.Sort;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    class SortController
    {
        public SortController()
        {
            this._bubbleSort = new BubbleSort();
            this._linearSort = new LinearSort();
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

        private BubbleSort _bubbleSort;
        private LinearSort _linearSort;
    }
}
