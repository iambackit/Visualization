using UnityEngine;
using Assets.Scripts.Enums;
using UnityEngine.UI;
using Assets.Scripts.Controllers;
using Assets.Scripts.Computing;
using Assets.Scripts.Data;

namespace Assets.Scripts.GUI
{
    public class OptionChanger : MonoBehaviour
    {
        public Text ShuffleText;
        public Text AlgorithmText;
        public Algorithm SelectedAlgorithm { get; private set; } = Algorithm.Selection;
        public Enums.Shuffle SelectedShuffle { get; private set; } = Enums.Shuffle.Random;
        public ShuffleController ShuffleController { get; set; }
        public CircleArray Objects { get; set; }
        public void SwitchAlgorithmForward()
        {
            this.SelectedAlgorithm = this.SelectedAlgorithm.Next();
            this.SetAlgorithmText();
        }

        public void SwitchAlgorithmBackward()
        {
            this.SelectedAlgorithm = this.SelectedAlgorithm.Previous();
            this.SetAlgorithmText();
        }

        public void SwitchShuffleForward()
        {
            this.SelectedShuffle = this.SelectedShuffle.Next();
            this.SetShuffleText();
            this.ShuffleController.Sort(this.Objects, this.SelectedShuffle);
        }

        public void SwitchShuffleBackward()
        {
            this.SelectedShuffle = this.SelectedShuffle.Previous();
            this.SetShuffleText();
            this.ShuffleController.Sort(this.Objects, this.SelectedShuffle);
        }

        private void SetAlgorithmText() => this.AlgorithmText.text = this.SelectedAlgorithm.ToString();
        private void SetShuffleText() => this.ShuffleText.text = this.SelectedShuffle.ToString().Replace('_',' ');
    }
}