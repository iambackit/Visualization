using Assets.Scripts.Data;
using Assets.Scripts.Computing;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Sort
{
    class CombSort : SortBase
    {
        public override IEnumerator Sort(CircleArray objects)
        {
            IsFinished = false;

            double gap = objects.Length;
            bool swaps = true;

            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;

                if (gap < 1)
                    gap = 1;

                int i = 0;
                swaps = false;

                while (i + gap < objects.Length)
                {
                    int igap = i + (int)gap;

                    GameObject iGO = Extension.GetObjectByActualPosition(objects, i);
                    GameObject igapGO = Extension.GetObjectByActualPosition(objects, igap);
                    if (Extension.Compare(iGO, igapGO))
                    {
                        Extension.Swap(iGO, igapGO);
                        swaps = true;
                    }

                    ++i;
                    yield return new WaitForSeconds(Time);
                }
            }

            IsFinished = true;
        }
    }
}
