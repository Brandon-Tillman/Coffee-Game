using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragIndredient : MonoBehaviour
{
    private Vector2 mousePosition;

    private float offsetX, offsetY;

    public static bool mouseButtonReleased;

    private void OnMouseDown()
    {
        mouseButtonReleased = false;
        offsetX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
        offsetY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
    }

    private void OnMouseDrag()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePosition.x - offsetX, mousePosition.y - offsetY);
    }

    private void OnMouseUp()
    {
        mouseButtonReleased = true;
    }

    private void OnCollisonEnter2D(Collision2D collision)
    {
        //
    }
}
