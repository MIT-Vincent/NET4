using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLook2 : MonoBehaviour {

    public Transform vrCamera;
    public float toggleAngle = 30.0f;
    public float speed = 10.0F;
    private CharacterController cc;
    public bool moveForward;
    // Use this for initialization
    void Start () {
        cc = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update () {

        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }

        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward * speed);
        }
    }
}
