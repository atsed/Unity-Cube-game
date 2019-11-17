using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailHero : MonoBehaviour
{
    public float speedHero;
    private Rigidbody heroRigidBody;
    private Vector3 heroPosition;


    void Start()
    {
        heroRigidBody = GetComponent<Rigidbody>();
        heroPosition.y = 0.625f;
    }


    void Update()
    {
        heroRigidBody.velocity = new Vector3(speedHero, 0, 0);
        

        if (Input.GetKeyDown(KeyCode.Space))
        {

            heroPosition.y = -heroPosition.y;            
            transform.position = transform.position + 2* heroPosition;       
        }
        

        if (Input.touchCount > 0)
        {
            heroPosition.y = -heroPosition.y;
            transform.position = transform.position + 2 * heroPosition;
        }

    }

}
        

