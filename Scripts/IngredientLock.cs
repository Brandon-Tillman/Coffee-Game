using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// need to make something to make this(the ingredients) disaapear and instanciate a new one
public class IngredientLock : MonoBehaviour
{
    //[SerializeField] private SpriteRenderer _renderer;
    private bool _dragging;

    private Vector2 _offset, _originalPosition;

    void Awake()
    {
        _originalPosition = transform.position;
    }

    void Update()
    {
        if(!_dragging) return;

        var mousePosition = GetMousePos();

        transform.position = mousePosition - _offset;
    }

    void OnMouseDown() 
    {
        _dragging = true;

        _offset = GetMousePos() - (Vector2)transform.position;
    }

    void OnMouseUp() 
    {
         transform.position = _originalPosition; // puts it back in its original place
            _dragging = false;
    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition); 
    }
}
