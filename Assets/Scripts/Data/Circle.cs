using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;

namespace Assets.Scripts.Data
{
    public class Circle : MonoBehaviour
    {
        public Color Color
        {
            get { return this._color; }
            set
            {
                this._color = value;
                this.gameObject.GetComponent<SpriteRenderer>().color = this._color;
            }
        }
        public Vector2 Position
        {
            get { return this._position; }
            set
            {
                this._position = value;
                this.transform.position = this._position;
            }
        }
        public int ActualIndex
        {
            get { return _actualIndex; }
            set { _actualIndex = value; }
        }

        public int OriginalIndex
        {
            get { return _originalIndex; }
            set { _originalIndex = value; }
        }

        #region private
        [SerializeField]
        private Vector2 _position;
        private Color _color;
        [SerializeField]
        private int _actualIndex;
        [SerializeField]
        private int _originalIndex;
        #endregion
    }
}