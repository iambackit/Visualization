using System.Collections;
using UnityEngine;
using Assets.Scripts.Interfaces;
using Assets.Scripts.GUI;
using Assets.Scripts.Enums;
using Assets.Scripts.Sort;

public class Controller : MonoBehaviour
{
    public GameObject CirclePrefab;
    public Color Start;
    public Color End;
    void Awake()
    {
        this._optionChanger = this.gameObject.GetComponent<OptionChanger>();
        this._randomSortController = new RandomSortController();
        
        this._circleGenerator = this.gameObject.AddComponent<CircleGenerator>();
        this._circleGenerator.CirclePrefab = this.CirclePrefab;

        this._colorCalculator = this.gameObject.AddComponent<ColorCalculator>();
        this._colorCalculator.Start = Start;
        this._colorCalculator.End = End;
        this._circleGenerator.ColorCalculator = this._colorCalculator;
        
        this._circles = this._circleGenerator.GenerateObjects();
    }

    public void RandomSorting()
    {
        this._randomSortController.Sort(this._circles, this._optionChanger.SelectedShuffle);
    }

    #region private
    private CircleGenerator _circleGenerator;
    private ColorCalculator _colorCalculator;
    private OptionChanger _optionChanger;
    private RandomSortController _randomSortController;

    private GameObject[] _circles;
    #endregion
}
