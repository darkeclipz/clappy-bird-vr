using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public ScoreController Score;

    void Update()
    {
        if(transform.position.x < -18.99)
        {
            transform.position = new Vector3(-18.99f, transform.position.y, transform.position.z);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision with object: " + col.gameObject.name);

        if (col.gameObject.tag == "Box" || col.gameObject.name == "Floor")
        {
            Score.resetScore = true;
            Debug.Log("Player/cube collision detected " + DateTime.Now.ToShortTimeString());
        }
    }
}
