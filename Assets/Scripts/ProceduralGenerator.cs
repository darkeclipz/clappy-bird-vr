using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralGenerator : MonoBehaviour {

    public GameObject CubePrefab;

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
            Instantiate(CubePrefab);


            LastSpawn = RespawnDelay;
        }
 
	}
}
