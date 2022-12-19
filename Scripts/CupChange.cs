using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupChange : MonoBehaviour
{
    public Sprite[] newSprite;
    public SpriteRenderer spriteRenderer;
    [HideInInspector]
    public int cupContains;

    //public GameObject[] customers;          // array of customers //JUST ADDED

    private void OnTriggerEnter2D(Collider2D other)
    {
         //Debug.Log("outside");
        if(other.name == "Empty")
        {
            cupContains = 100; // dont think this needs to be there
            Debug.Log(" = 100 now");
            spriteRenderer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = newSprite[0];
        }
        if(other.name == "Coffee_bean") // names of the ingredients
        {
            cupContains = 1;
            Debug.Log(" = 1 now");
            spriteRenderer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = newSprite[1];
        }
        if(other.name == "Grapes")
        {
            cupContains = 2;
            Debug.Log(" = 2 now");
            spriteRenderer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = newSprite[2];
        }
        if(other.name == "Green Tea Bag")
        {
            cupContains = 3;
            Debug.Log(" = 3 now");
            spriteRenderer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = newSprite[3];
        }
        if(other.name == "Chocolate")
        {
            cupContains = 4;
            Debug.Log(" = 4 now");
            spriteRenderer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = newSprite[4];
        }
        if(other.name == "Lemon")
        {
            cupContains = 5;
            Debug.Log(" = 5 now");
            spriteRenderer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = newSprite[5];
        }
        if(other.name == "Strawberry")
        {
            cupContains = 6;
            Debug.Log(" = 6 now");
            spriteRenderer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = newSprite[6];
        }
    }
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
}