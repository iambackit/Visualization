using Assets.Scripts.Data;
using Assets.Scripts.Shuffle;
using Assets.Scripts.Sort;
using UnityEngine;

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

        public void Sort(GameObject[] objects, Enums.Shuffle selectedSorting)
        {
            this.Sort(objects); //todo - use better sorting algorithms

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

        private void Sort(GameObject[] objects)
        {
            for (int i = 0; i < objects.Length - 1; i++)
            {
                GameObject prev = objects[i];
                for (int j = i + 1; j < objects.Length; j++)
                {
                    GameObject next = objects[j];

                    int prevPlace = prev.GetComponent<Circle>().ActualIndex;
                    int nextPlace = next.GetComponent<Circle>().ActualIndex;

                    if (prevPlace > nextPlace)
                    {
                        Vector2 tmpPosition = prev.GetComponent<Circle>().Position;
                        prev.GetComponent<Circle>().Position = next.GetComponent<Circle>().Position;
                        next.GetComponent<Circle>().Position = tmpPosition;

                        int tmpPlace = prev.GetComponent<Circle>().ActualIndex;
                        prev.GetComponent<Circle>().ActualIndex = next.GetComponent<Circle>().ActualIndex;
                        next.GetComponent<Circle>().ActualIndex = tmpPlace;
                    }
                }
            }
        }
    }
}
