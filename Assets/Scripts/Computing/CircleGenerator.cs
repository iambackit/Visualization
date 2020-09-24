using Assets.Scripts.Data;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UIElements;

namespace Assets.Scripts.Computing
{
    public class CircleGenerator : MonoBehaviour
    {
        public GameObject CirclePrefab { get; set; }
        public ColorCalculator ColorCalculator { get; set; }
        public GameObject[] Circles { get { return this._circles; } }
        private void Awake()
        {
            Size resolution = new Size(1920, 1080);
            int circleSize = 120;

            this._cols = resolution.Width / circleSize - this._guiCoveredCols;
            this._rows = resolution.Height / circleSize;
            this._offset = circleSize / 100f;
            this._objectCount = this._cols * this._rows;

            this._circles = new GameObject[this._objectCount];
        }

        public GameObject[] GenerateObjects()
        {
            GameObject container = GameObject.Find("CircleContainer");

            int idx = 0;
            float xPos = ((this._cols / 2) * -this._offset) + (this._offset / 2f) + this._offset;
            float yPos = (this._rows / 2) * -this._offset;

            float xPosAct;
            for (int y = 0; y < this._rows; y++)
            {
                xPosAct = xPos;
                for (int x = 0; x < this._cols; x++)
                {
                    Vector2 position = new Vector2(xPosAct, yPos);
                    this._circles[idx] = Instantiate(CirclePrefab, position, Quaternion.identity);
                    this._circles[idx].GetComponent<Circle>().Position = position;
                    this._circles[idx].GetComponent<Circle>().Color = this.ColorCalculator.GetActColor(idx + 1, this._objectCount);
                    this._circles[idx].GetComponent<Circle>().ActualIndex = idx;
                    this._circles[idx].GetComponent<Circle>().OriginalIndex = idx;
                    this._circles[idx].gameObject.transform.parent = container.transform;
                    idx++;

                    xPosAct += this._offset;
                }
                yPos += this._offset;
            }

            return this._circles;
        }

        #region private
        private int _cols;
        private int _rows;
        private float _offset;
        private int _objectCount;
        private int _guiCoveredCols = 3;

        GameObject[] _circles;
        #endregion
    }
}