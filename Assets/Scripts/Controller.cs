using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Interfaces;

public class Controller : MonoBehaviour
{
    public GameObject CirclePrefab;
    public Color Start;
    public Color End;
    void Awake()
    {
        this._circleGenerator = this.gameObject.AddComponent<CircleGenerator>();
        this._circleGenerator.CirclePrefab = this.CirclePrefab;

        this._colorCalculator = this.gameObject.AddComponent<ColorCalculator>();
        this._colorCalculator.Start = Start;
        this._colorCalculator.End = End;
        this._circleGenerator.ColorCalculator = this._colorCalculator;
        
        this._circles = this._circleGenerator.GenerateObjects();

        this._randomSort = this.gameObject.AddComponent<RandomSort>();
        this.Randomize();

        this._sorter = this.gameObject.AddComponent<LinearSort>();
        this.StartCoroutine(ExecuteAfterTime(3));
    }

    #region private
    private CircleGenerator _circleGenerator;
    private ColorCalculator _colorCalculator;
    private ISort _sorter;
    private ISort _randomSort;

    private GameObject[] _circles;
    private void Randomize()
    {
        this._randomSort.Sort(this._circles);
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        this._sorter.Sort(this._circles);
    }
    #endregion
}
