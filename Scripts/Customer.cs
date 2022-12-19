using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// STOP REDOING RIGHT HERE IF THE CODE GOES WRONG. FOR THE LOVE GOD AND ALL THE GREEKS GODS, PLEASE DONT GO PAST THIS
public class Customer : MonoBehaviour
{
    public Sprite[] newSprite;              // for the cup sprites
    public SpriteRenderer spriteRenderer;   // for the cup
    public SpriteRenderer customerSprite;
    private bool _character;                // to see if the character is there or not
    [HideInInspector]
    public string drinkOrder;               // string to call orders of drinks

    public Text textElement;                // For the drink orders
    private Animator animation;              // the animator for customer
    int order;                              // the customer ordering a random num
    public GameObject[] customers;          // array of customers
    public GameObject cup;                  // the cup in use
    private Vector2 _originalPosition;      // makes the original position 
    int randomNumber;                       // used for randomizing orders of drinks

    private void Awake()                    //Called once when the game starts
    {
        _character = true;
        _originalPosition = transform.position;     //gets the position of the cup now to equal the original position. Used to make cup go back to this place
        randomNumber = Random.Range(1,7);           // The range of numbers to go to
        order = randomNumber;                       //How i randomized the orders
        Debug.Log("Rand is "+ randomNumber);
        Debug.Log("Order is "+ order);



    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        animation = gameObject.GetComponent<Animator>();
        animation.SetTrigger("Click");              // this makes the character play an animation

        if (order == cup.GetComponent<CupChange>().cupContains) // this is where the order matches the cup and i need to make sure that i find the right place to put order
        {        

            Debug.Log("Order in correct = " + order);
            Debug.Log("CORRECT");

            animation = gameObject.GetComponent<Animator>();
            animation.SetTrigger("Click");          // this makes the character play an animation
            animation.SetTrigger("Correct");

            transform.position = _originalPosition;
            spriteRenderer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = newSprite[0];

            animation.ResetTrigger("Click");
            cup.gameObject.SetActive(true);         // if uncommented, the cup disappear

            
            _character = false;
            
        }
         else                                       // if the order is wrong
        {
            animation.SetTrigger("Click");
            Debug.Log("The drink is incorrect");
        }
    }
    
    public void Update()
    {
        textElement.text = drinkOrder;
            
        if (order == 1)
        {
            drinkOrder = "Order: Coffee";
        }
        if (order == 2)
        {
            drinkOrder = "Order: Grape Juice";
        }
        if (order == 3)
        {
            drinkOrder = "Order: Green Tea";
        }
        if (order == 4)
        {
            drinkOrder = "Order: Hot Chocolate";
        }
        if (order == 5)
        {
            drinkOrder = "Order: Lemon Ginger Tea";
        }
        if (order == 6)
        {
            drinkOrder = "Order:  Strawberry Milk Tea";
        }
        // This makes the customer only intsantiate when pressed G and destroys object in 2 seconds
        if(!_character && Input.GetKeyDown(KeyCode.G))
        {
            Destroy(this.gameObject, 2); // fine

            randomNumber = Random.Range(1,7);
            order = randomNumber;

            Instantiate(customers[1]);
            _character = true;
        }
    }
}
