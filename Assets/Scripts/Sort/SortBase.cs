using Assets.Scripts.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

namespace Assets.Scripts.Sort
{
    public abstract class SortBase : MonoBehaviour, ISort
    {
        public static float Time = 1f;
        public static bool IsFinished = true;
        public abstract IEnumerator Sort(GameObject[] objects);
    }
}
