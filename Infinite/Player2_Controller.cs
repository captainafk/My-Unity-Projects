﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2_Controller : MonoBehaviour {

	public float jumpVelocity;
	public float gravity;
	private Rigidbody rb;
	public SphereCollider col;
	public LayerMask groundLayers;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		col = GetComponent<SphereCollider>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.Space) && IsGrounded()){
			//GetComponent<Rigidbody>().velocity = Vector3.forward * jumpVelocity;
			rb.AddForce(Vector3.forward * jumpVelocity, ForceMode.Impulse);
		}else {
			rb.AddForce(Vector3.back * gravity);
		}
	}
	
	private bool IsGrounded() {
		
		return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.center.y, col.bounds.min.z), col.radius * .9f, groundLayers);
		
	}
}
