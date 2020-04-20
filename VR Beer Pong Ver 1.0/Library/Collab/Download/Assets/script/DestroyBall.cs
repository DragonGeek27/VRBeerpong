using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		

    void OnTriggerEnter(Collider other)
    {
		
		GameObject.Find ("ballSpawner2").GetComponent<SpawnBall2> ().spawnMe2 = true;
		Destroy(gameObject);

    }


}
