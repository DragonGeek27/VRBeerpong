using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall2 : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		

    void OnTriggerEnter(Collider other)
    {
		
		GameObject.Find ("ballSpawner1").GetComponent<SpawnBall> ().spawnMe = true;
		Destroy(gameObject);

    }


}
