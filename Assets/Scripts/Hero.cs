using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    private Vector3 heroPosition;
    public GameObject PanelDead;

    void Start()
    {
        heroPosition.y = 0.625f;
        PanelDead.gameObject.SetActive(false);
    }


    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            heroPosition.y = -heroPosition.y;
            transform.position = transform.position + 2 * heroPosition;

        }

        if (Input.touchCount > 0)
        {
            switch (Input.GetTouch(0).phase)
            {
                case TouchPhase.Began:
                    // code to run when touch begins here...
                    heroPosition.y = -heroPosition.y;
                    transform.position = transform.position + 2 * heroPosition;
                    break;
                case TouchPhase.Moved:
                    break;
                case TouchPhase.Stationary:
                    // code to run when touch is being dragged here...
                    break;
                case TouchPhase.Ended:
                    // code to run when touch is lifted up and finished here...
                    break;
                case TouchPhase.Canceled:
                    // code to run when touch is interrupted and does not get to run the 'Ended' case here... (jumps from dragging to being canceled by some interruption like a phone call)
                    break;
            }
        }
        /*       if (Input.touchCount == 1)
           {
               Debug.Log("Touch");
               heroPosition.y = -heroPosition.y;
               transform.position = transform.position + 2 * heroPosition;

           }

       */

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Game over");
        Destroy(gameObject);
        PanelDead.gameObject.SetActive(true);
    }

}


