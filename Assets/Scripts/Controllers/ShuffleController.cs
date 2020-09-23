using Assets.Scripts.Shuffle;
using Assets.Scripts.Sort;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    class ShuffleController
    {
        public ShuffleController()
        {
            this._almostSort = new AlmostSort();
            this._randomSort = new RandomSort();
            this._reversedSort = new ReversedSort();

            this._linearSort = new LinearSort();
        }

        public void Sort(GameObject[] objects, Enums.Shuffle selectedSorting)
        {
            this._linearSort.Sort(objects); //todo - use better sorting algorithms

            switch (selectedSorting)
            {
                case Enums.Shuffle.Almost_Sorted:
                    this._almostSort.Shuffle(objects);
                    break;
                case Enums.Shuffle.Random:
                    this._randomSort.Shuffle(objects);
                    break;
                case Enums.Shuffle.Sorted:
                    break;
                case Enums.Shuffle.Reversed:
                    this._reversedSort.Shuffle(objects);
                    break;
                default:
                    break;
            }
        }
        
        private AlmostSort _almostSort;
        private RandomSort _randomSort;
        private ReversedSort _reversedSort;

        private LinearSort _linearSort;
    }
}
