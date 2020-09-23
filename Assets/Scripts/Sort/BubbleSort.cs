using Assets.Scripts.Data;
using Assets.Scripts.Interfaces;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Sort
{
    class BubbleSort : MonoBehaviour, ISort
    {
        public IEnumerator Sort(GameObject[] objects)
        {
            for (int p = 0; p < objects.Length - 2; p++)
            {
                for (int i = 0; i < objects.Length - 2; i++)
                {
                    GameObject prev = objects[i];
                    GameObject next = objects[i + 1];

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

                    yield return new WaitForSeconds(.0001f);
                }
            }
        }
    }
}
