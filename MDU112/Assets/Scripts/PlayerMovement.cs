using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour 
{
    private Rigidbody2D Player;
    private Vector2 UserInput;
    public float MovementSpeed = 10;

	// Use this for initialization
	void Start () 
    {
        //ask our game object for the rigidbody 2d component
        Player = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //retrieves the user input
        float Horizontal = Input.GetAxis("Horizontal");

        //stores the user inputs as a variable
        UserInput = new Vector2(Horizontal, 0);
	}

    void FixedUpdate()
    {
        Vector2 NewPosition = transform.position;
        NewPosition += UserInput * MovementSpeed * Time.fixedDeltaTime;
        Player.MovePosition(NewPosition);
    }
}
