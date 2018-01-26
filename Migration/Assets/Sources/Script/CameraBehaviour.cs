using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour {


    Vector3 dist;
    public Transform player;
	// Use this for initialization
	void Start ()
    {
        dist = transform.position - player.position;	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = player.position + dist;
	}
}
