using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookieHandler : MonoBehaviour
{

    private int cookiesCollected = 0;


    // OnTriggerEnter2D is called once, when two GameObjects with Collider2Ds hit each other
        // - One GameObject must have a Rigidbody2D as well
        // - One of the Collider2Ds must be a Trigger
    void OnTriggerEnter2D(Collider2D coll) {
        Debug.Log(coll);
        if(coll.tag.Equals("Cookie")){
            cookiesCollected += 1;
            Destroy(coll.gameObject);

        }
    }

    // OnCollisionEnter2D is called once, when two GameObjects with Collider2Ds hit each other
        // - One GameObject must have a Rigidbody2D as well
    void OnCollisionEnter2D(Collision2D coll) {
        if(coll.gameObject.tag.Equals("Finish")){
            print("You won the game");
        }
    }
}
