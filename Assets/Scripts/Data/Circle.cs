using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        #region private
        [SerializeField]
        private Vector2 _position;
        private Color _color;
        [SerializeField]
        private int _value;
        #endregion
    }
}