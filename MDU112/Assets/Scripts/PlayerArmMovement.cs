using UnityEngine;
using System.Collections;

public class PlayerArmMovement : MonoBehaviour 
{

    private Vector2 userInput;
    public float rotationSpeed = 100f;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {

        float horizontal = Input.GetAxis("Vertical");

        // store the axes in the user input variable
        userInput = new Vector2(horizontal, 0);

        // Method 3 - Part a (rotation)
        Vector3 rotationDelta = new Vector3(0, 0, -horizontal * rotationSpeed * Time.deltaTime);
        transform.Rotate(rotationDelta);

	}
}
