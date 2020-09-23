using System.Collections;
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
    }

    #region private
    private CircleGenerator _circleGenerator;
    private ColorCalculator _colorCalculator;

    private GameObject[] _circles;
    #endregion
}
