using UnityEngine;
using System.Collections;

public class PlayerPickUp : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
	    
	}
	
	// Update is called once per frame
	void Update () 
    {
	    
	}

    void OnCollisionEnter2D(Collision2D Enemy)
    {
        if (Enemy.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Hit");
            Enemy.transform.parent = gameObject.transform;
            
        }
    }
}
