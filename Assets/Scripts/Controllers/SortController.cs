using Assets.Scripts.Shuffle;
using Assets.Scripts.Sort;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

namespace Assets.Scripts.Controllers
{
    class SortController : MonoBehaviour
    {
        private void Start()
        {
            this._linearSort = this.gameObject.AddComponent<LinearSort>();
            this._bubbleSort = this.gameObject.AddComponent<BubbleSort>();
        }
        public IEnumerator Sort(GameObject[] objects, Enums.Algorithm selectedSorting)
        {
            switch (selectedSorting)
            {
                case Enums.Algorithm.Linear:
                    return this._linearSort.Sort(objects);
                case Enums.Algorithm.Bubble:
                    return this._bubbleSort.Sort(objects);
            }

            return null;
        }

        private LinearSort _linearSort;
        private BubbleSort _bubbleSort;
    }
}
