using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class CopyScript : NetworkBehaviour
{
    public enum BodyPart { Head, LHand, RHand };
    public BodyPart bodyPart = BodyPart.Head;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            switch (bodyPart)
            {
                case BodyPart.Head://head
                    transform.position = ControllerManager.Instance.head.transform.position;
                    transform.rotation = ControllerManager.Instance.head.transform.rotation;
                    break;
                case BodyPart.LHand://lefthand
                    transform.position = ControllerManager.Instance.leftHand.transform.position;
                    transform.rotation = ControllerManager.Instance.leftHand.transform.rotation;
                    break;
                case BodyPart.RHand://righthand
                    transform.position = ControllerManager.Instance.rightHand.transform.position;
                    transform.rotation = ControllerManager.Instance.rightHand.transform.rotation;
                    break;
            }
        }
	}
}
