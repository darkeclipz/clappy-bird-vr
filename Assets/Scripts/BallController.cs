using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public float rotationSpeed = 2f;

    private Vector3 initialPosition;

    void Start()
    {
        var p = transform.position;
        initialPosition = new Vector3(p.x, p.y, p.z);
    }

	// Update is called once per frame
	void Update () {

        transform.Rotate(0, rotationSpeed, 0);

	}
}
