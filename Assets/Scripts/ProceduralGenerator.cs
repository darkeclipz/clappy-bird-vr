using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralGenerator : MonoBehaviour {

    public GameObject CubePrefab;
    public ScoreController score;

    float LastSpawn = 0f;
    public float RespawnDelay = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        LastSpawn -= Time.deltaTime;

        if(LastSpawn < 0f)
        {
            var obj = Instantiate(CubePrefab);
            var cube = obj.GetComponent<CubeController>();
            cube.score = score;
            LastSpawn = RespawnDelay;
        }
 
	}
}
