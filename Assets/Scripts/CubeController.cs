using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    private bool success;
    public ScoreController score;

	// Use this for initialization
	void Start () {
        var cp = transform.position;
        var randomY = Random.Range(-4, 8);
        transform.position = new Vector3(120, cp.y + randomY + 1f, cp.z);
	}
	
	// Update is called once per frame
	void Update () {

        var cp = transform.position;
        var np = new Vector3(cp.x - .1f, cp.y, cp.z);
        transform.position = np;

        if (np.x < -40f)
        {
            Destroy(gameObject);
        }

        if(!success && transform.position.x < -18.99f)
        {
            success = true;
            score.incrementScore = true;
        }
    }
}
