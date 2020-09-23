using Assets.Scripts.Data;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Sort
{
    class BubbleSort : ISort
    {
        public void Sort(GameObject[] objects)
        {
            for (int i = 0; i < objects.Length - 2; i++)
            {
                GameObject prev = objects[i];
                for (int j = 0; j < objects.Length - 2; j++)
                {
                    GameObject next = objects[j];

                    int prevPlace = prev.GetComponent<Circle>().Place;
                    int nextPlace = next.GetComponent<Circle>().Place;

                    if (prevPlace > nextPlace)
                    {
                        Vector2 tmpPosition = prev.GetComponent<Circle>().Position;
                        prev.GetComponent<Circle>().Position = next.GetComponent<Circle>().Position;
                        next.GetComponent<Circle>().Position = tmpPosition;

                        int tmpPlace = prev.GetComponent<Circle>().Place;
                        prev.GetComponent<Circle>().Place = next.GetComponent<Circle>().Place;
                        next.GetComponent<Circle>().Place = tmpPlace;
                    }
                }
            }
        }
    }
}
