using Assets.Scripts.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Sort
{
    public abstract class SortBase : MonoBehaviour, ISort
    {
        public static float Time = 1f;
        public abstract IEnumerator Sort(GameObject[] objects);
    }
}
