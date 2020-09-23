using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public int Place
    {
        get { return _place; }
        set { _place = value; }
    }

    #region private
    [SerializeField]
    private Vector2 _position;
    private Color _color;
    [SerializeField]
    private int _place;
    #endregion
}
