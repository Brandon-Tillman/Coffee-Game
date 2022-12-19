using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class DragDrop : MonoBehaviour
{
        private Vector2 _originalPosition;

        void Awake()
    {
        _originalPosition = transform.position;
    }

    
    Vector3 mousePositionOffset;

    private Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        //Debug.Log("Mouse Down");
        mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPosition() + mousePositionOffset;
    }

    private void OnMouseUp()
    {
        transform.position = _originalPosition;

    }
    private void OnCollisonEnter(Collider2D other)
    {
        transform.position = _originalPosition;
    }
}
