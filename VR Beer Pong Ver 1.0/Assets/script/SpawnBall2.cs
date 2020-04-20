using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SpawnBall2 : NetworkBehaviour
{
    public GameObject player;
    public GameObject ballPrefab;
    public Transform ballSpawn;
	public bool spawnMe2;
	//public SpawnBall switchSides2;

    // Use this for initialization

	void Awake()
	{
		spawnMe2 = false;
	}

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(2)) {
			Debug.Log("Yes");
			CmdspawnBall();
		}

*/
        
        CmdspawnBall();
		if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
		{
			//CmdspawnBall();
		}

        //if (!isLocalPlayer)
        //{
        //  return;
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
		spawnMe2 = true;
	}
*/
    [Command]
    void CmdspawnBall()
    {

        if (player != null)
        {
            if (spawnMe2 == true)
            {
                var ball = Instantiate(
                    ballPrefab,
                    ballSpawn.transform.position,
                    ballSpawn.transform.rotation);
                NetworkServer.SpawnWithClientAuthority(ball, player);
                //NetworkServer.Spawn(ball);
                spawnMe2 = false;

                //GameObject.Find ("ballSpawner1").GetComponent<SpawnBall> ().spawnMe = true;
                Debug.Log(spawnMe2);
            }
        }

    }
}