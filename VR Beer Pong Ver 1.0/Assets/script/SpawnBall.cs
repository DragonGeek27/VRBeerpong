using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SpawnBall : NetworkBehaviour
{
    public GameObject ballPrefab;
    public GameObject player;
    public Transform ballSpawn;
	public bool spawnMe;
	//public GameObject spawn2;
	//public SpawnBall2 switchSides;

    // Use this for initialization

	void Awake()
	{
		spawnMe = true;
	}

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(1)) {
			Debug.Log("Yes");
			CmdspawnBall();
		}*/

        
            CmdspawnBall();
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
            {
                //CmdspawnBall();
            }

            //if (!isLocalPlayer)
            //{
            //    return;
            //}
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player = other.gameObject;
        }
    }
    public override void OnStartLocalPlayer()
    {
        //GetComponent<MeshRenderer>().material.color = Color.blue;
    }
    /*	[Command]
        public void SetTrue() {
            spawnMe = true;
        }
    */
    [Command]
    void CmdspawnBall()
    {

        if (player != null)
        {
            if (spawnMe == true)
            {
                var ball = Instantiate(
                    ballPrefab,
                    ballSpawn.transform.position,
                    ballSpawn.transform.rotation);

                NetworkServer.SpawnWithClientAuthority(ball, player);
                //NetworkServer.Spawn(ball);
                spawnMe = false;

                //GameObject.Find ("ballSpawner2").GetComponent<SpawnBall2> ().spawnMe2 = true;
                Debug.Log(spawnMe);
            }

        }
    }
		
}