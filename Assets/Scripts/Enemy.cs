using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speedEnemy;
    public float accelerationEnemy;
    private Rigidbody enemyRigidBody;
    public GameObject PanelMain;
    public GameObject PanelDead;


    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (PanelMain.gameObject.activeInHierarchy == false)
        {

            enemyRigidBody.velocity = new Vector3(-speedEnemy , 0, 0);
            speedEnemy += 0.01f;
        }
        if (PanelDead.gameObject.activeInHierarchy == true)
        {
            speedEnemy = 0;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "DestroyEnemy")
        {
            Destroy(gameObject);

        }
    }

}
