using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour
{
    [SerializeField]
    Behaviour[] componentsToDisable;
    public GameObject TempararyPlayer;
    public GameObject TempararyLHand;
    public GameObject TempararyRHand;

    //public OVRPlayerController pc;
    //public GameObject ovrCam;
    // Use this for initialization
    void Start () {
        if(!isLocalPlayer)
        {
            for (int i = 0; i < componentsToDisable.Length; i++)
            {
                componentsToDisable[i].enabled = false;
                
            }
            
        }
        if (isLocalPlayer)
        {
            TempararyPlayer.SetActive(false);
            TempararyLHand.SetActive(false);
            TempararyRHand.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
