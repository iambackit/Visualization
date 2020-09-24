using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Data
{
    public class CircleArray
    {
        public GameObject[] Circles { get; set; }
        public int Length => Circles.Length;
        public CircleArray(int arraySize)
        {
            this.Circles = new GameObject[arraySize];
        }

        public GameObject this[int i]
        {
            get { return Circles[i]; }
            set { Circles[i] = value; }
        }
    }
}
