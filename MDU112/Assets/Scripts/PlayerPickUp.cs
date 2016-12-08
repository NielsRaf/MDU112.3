using UnityEngine;
using System.Collections;

public class PlayerPickUp : MonoBehaviour 
{
    public GameObject Enemy;

	void Start () 
    {
	    
	}

	void Update () 
    {
        if (Input.GetButton("Jump"))
        {
            Enemy.transform.parent = null;
            Rigidbody2D EnemyRigidBody = Enemy.AddComponent<Rigidbody2D>();
        }
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
