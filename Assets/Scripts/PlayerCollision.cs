using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision with object: " + col.gameObject.name);

        if (col.gameObject.tag == "Box")
        {
            Debug.Log("Player/cube collision detected " + DateTime.Now.ToShortTimeString());
        }
    }
}
