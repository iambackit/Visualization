using UnityEngine;
using Assets.Scripts.GUI;
using Assets.Scripts.Computing;
using Assets.Scripts.Sort;
using UnityEngine.UI;

namespace Assets.Scripts.Controllers
{
    public class Controller : MonoBehaviour
    {
        public GameObject CirclePrefab;
        public Slider SliderSpeed;
        public Color Start;
        public Color End;
        void Awake()
        {
            this._optionChanger = this.gameObject.GetComponent<OptionChanger>();
            this._sortController = this.gameObject.AddComponent<SortController>();
            this._randomSortController = new ShuffleController();

            this.SliderSpeed.onValueChanged.AddListener(delegate { ValueChangeCheck(); });

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

        public void Sort()
        {
            StartCoroutine(this._sortController.Sort(this._circles, this._optionChanger.SelectedAlgorithm));
        }

        private void ValueChangeCheck()
        {
            SortBase.Time = SliderSpeed.maxValue - SliderSpeed.value;
        }

        #region private
        private CircleGenerator _circleGenerator;
        private ColorCalculator _colorCalculator;
        private OptionChanger _optionChanger;
        
        private ShuffleController _randomSortController;
        private SortController _sortController;
        private GameObject[] _circles;
        #endregion
    }
}