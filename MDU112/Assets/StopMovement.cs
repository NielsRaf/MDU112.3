using UnityEngine;
using System.Collections;

public class StopMovement : MonoBehaviour {

    public Rigidbody2D Enemy;

	void Start () 
    {
	
	}

	void Update () 
    {

	
	}

    void OnCollisionEnter2D(Collision2D Player)
    {
        if (Player.gameObject.CompareTag("Player"))
        {
            Enemy.velocity = new Vector2(0,0);
            Debug.Log("Stop");
        }
    }
}
