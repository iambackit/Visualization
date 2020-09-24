using Assets.Scripts.Data;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Interfaces
{
    interface ISort
    {
        IEnumerator Sort(CircleArray objects);
    }
}