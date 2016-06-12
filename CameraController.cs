//*************************************************************************
// Name: CameraController.cs
// Programmer: Curtis Frank
// Date: 5/15/2016
//*************************************************************************

using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    // player object
    public GameObject player;

    // variable to hold offset value
    private Vector3 offset;

	// Use this for initialization*****************************************
	void Start() 
    {
        // subtract player position from camera position
        // to find offset
        offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is called once per frame but is guaranteed to
    // run after all items have been updated*******************************
	void LateUpdate() 
    {
	    // set the transform positon of the camera to the
        // player position plus the offset
        transform.position = player.transform.position + offset;
	}
}
