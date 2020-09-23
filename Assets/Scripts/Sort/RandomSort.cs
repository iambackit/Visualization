using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Interfaces;

namespace Assets.Scripts.Sort
{
    public class RandomSort : MonoBehaviour, ISort
    {
        public void Sort(GameObject[] circles)
        {
            int r0, r1;

            int loop = 1000;
            for (int i = 0; i < loop; i++)
            {
                r0 = Random.Range(0, circles.Length - 1);
                r1 = Random.Range(0, circles.Length - 1);

                Vector2 r0Position = circles[r0].GetComponent<Circle>().Position;
                circles[r0].GetComponent<Circle>().Position = circles[r1].GetComponent<Circle>().Position;
                circles[r1].GetComponent<Circle>().Position = r0Position;

                int r0Place = circles[r0].GetComponent<Circle>().Place;
                circles[r0].GetComponent<Circle>().Place = circles[r1].GetComponent<Circle>().Place;
                circles[r1].GetComponent<Circle>().Place = r0Place;
            }
        }
    }
}