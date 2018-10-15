using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveTest : MonoBehaviour {

    public GameObject camera;

    void Update()
    {
        var currentPosition = camera.transform.position;
        var newPosition = new Vector3(currentPosition.x, currentPosition.y + 0.01f, currentPosition.z);

        if (newPosition.y > 10)
        {
            newPosition.y = 0;
        }

        camera.transform.position = newPosition;
    }
}
