using Assets.Scripts.Interfaces;
using Assets.Scripts.Enums;
using UnityEngine;

namespace Assets.Scripts.Sort
{
    class RandomSortController
    {
        public RandomSortController()
        {
            this._almostSort = new AlmostSort();
            this._randomSort = new RandomSort();
        }

        public void Sort(GameObject[] objects, Shuffle selectedSorting)
        {
            switch (selectedSorting)
            {
                case Shuffle.Almost_Sorted:
                    this._almostSort.Sort(objects);
                    break;
                case Shuffle.Random:
                    this._randomSort.Sort(objects);
                    break;
                default:
                    break;
            }
        }
        
        private AlmostSort _almostSort;
        private RandomSort _randomSort;
    }
}
