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
        switch(this._optionChanger.SelectedShuffle)
        {
            case Shuffle.Almost_Sorted:
                randomSort = new AlmostSort();
                break;
            case Shuffle.Random:
                randomSort = new RandomSort();
                break;
        }

        randomSort.Sort(this._circles);
    }
    #region private
    private CircleGenerator _circleGenerator;
    private ColorCalculator _colorCalculator;
    private OptionChanger _optionChanger;

    private GameObject[] _circles;
    private ISort randomSort;
    #endregion
}
