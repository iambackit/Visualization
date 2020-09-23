using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Interfaces
{
    interface ISort
    {
        IEnumerator Sort(GameObject[] objects);
    }
}