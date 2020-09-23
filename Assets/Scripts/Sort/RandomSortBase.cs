using UnityEngine;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Data;

public class RandomSortBase : ISort
{
    public virtual void Sort(GameObject[] circles)
    {
        int r0, r1;

        for (int i = 0; i < LoopCount; i++)
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

    protected int LoopCount { get; set; }
}
