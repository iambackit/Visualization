using UnityEngine;
using UnityEditor.UI;
using Assets.Scripts.Enums;
using UnityEngine.UI;

namespace Assets.Scripts.GUI
{
    public class OptionChanger : MonoBehaviour
    {
        public Text ShuffleText;
        public Text AlgorithmText;
        public void SwitchAlgorithmForward()
        {
            this._selectedAlgorithm = this._selectedAlgorithm.Next();
            this.SetAlgorithmText();
        }

        public void SwitchAlgorithmBackward()
        {
            this._selectedAlgorithm = this._selectedAlgorithm.Previous();
            this.SetAlgorithmText();
        }

        public void SwitchShuffleForward()
        {
            this._selectedShuffle = this._selectedShuffle.Next();
            this.SetShuffleText();
        }

        public void SwitchShuffleBackward()
        {
            this._selectedShuffle = this._selectedShuffle.Previous();
            this.SetShuffleText();
        }

        private Algorithm _selectedAlgorithm = Algorithm.Linear;
        private Shuffle _selectedShuffle = Shuffle.Random;

        private void SetAlgorithmText() => this.AlgorithmText.text = this._selectedAlgorithm.ToString();
        private void SetShuffleText() => this.ShuffleText.text = this._selectedShuffle.ToString().Replace('_',' ');
    }
}