using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Host : MonoBehaviour {
    public OVRGrabbable grabbable;
    public CustomNetworkManager networkManager;
    private bool host;
    // Use this for initialization
    void Start () {
        host = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (grabbable.isGrabbed == true)
        {
            if (host == true)
            {
                networkManager.StartHost();
                host = false;
            }
        }

    }
}
