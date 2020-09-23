﻿using UnityEngine;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Data;

namespace Assets.Scripts.Sort
{
    public class LinearSort : ISort
    {
        public void Sort(GameObject[] objects)
        {
            for (int i = 0; i < objects.Length - 1; i++)
            {
                GameObject prev = objects[i];
                for (int j = i + 1; j < objects.Length; j++)
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