using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerManager : MonoBehaviour {

    public GameObject head;
    public GameObject leftHand;
    public GameObject rightHand;

    public static ControllerManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

    }
    private void OnDestroy()
    {
        if (Instance == null)
        {
            Instance = null;
        }
    }
}
