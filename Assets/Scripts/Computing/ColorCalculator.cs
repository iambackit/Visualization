using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Computing
{
    public class ColorCalculator : MonoBehaviour
    {
        public Color Start { get; set; }
        public Color End { get; set; }

        public Color GetActColor(int idx, int count)
        {
            float percent = (idx + 1f) / count;

            float resultRed = Start.r + percent * (End.r - Start.r);
            float resultGreen = Start.g + percent * (End.g - Start.g);
            float resultBlue = Start.b + percent * (End.b - Start.b);

            return new Color(resultRed, resultGreen, resultBlue);
        }

        public Color GenerateRandomColor => new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

        public void SetColorToButton(Button b, Color c)
        {
            b.GetComponent<Image>().color = new Color(c.r, c.g, c.b, 1f);
        }
    }
}
