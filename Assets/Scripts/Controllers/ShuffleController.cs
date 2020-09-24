using Assets.Scripts.Shuffle;
using Assets.Scripts.Computing;
using UnityEngine;
using Assets.Scripts.Data;

namespace Assets.Scripts.Controllers
{
    public class ShuffleController
    {
        public ShuffleController()
        {
            this._almostSort = new AlmostSort();
            this._randomSort = new RandomSort();
            this._reversedSort = new ReversedSort();
        }

        public void Sort(CircleArray objects, Enums.Shuffle selectedSorting)
        {
            this.Sort(objects);

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

        private void Sort(CircleArray objects)
        {
            int smallest;
            for (int i = 0; i < objects.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < objects.Length; j++)
                {
                    if (Extension.Compare(Extension.GetObjectByActualPosition(objects, smallest), Extension.GetObjectByActualPosition(objects, j)))
                    {
                        smallest = j;
                    }
                }
                Extension.Swap(Extension.GetObjectByActualPosition(objects, smallest), Extension.GetObjectByActualPosition(objects, i));
            }
        }
    }
}
