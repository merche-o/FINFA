﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float moveSpeed = 1;
	private Animator anim;
	private bool isMoving;
	private Vector2 lastMove;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		isMoving = false;

		
	}
	
	// Update is called once per frame
	void Update () {

		isMoving = false;
		if (Input.GetAxisRaw ("Horizontal") > 0.5f || Input.GetAxisRaw ("Horizontal") < -0.5f) {
			transform.Translate (new Vector3 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime, 0f));
			isMoving = true;
			lastMove = new Vector2 (Input.GetAxisRaw ("Horizontal"), 0); 
		}
		if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f) {
			transform.Translate(new Vector3(0f,Input.GetAxisRaw("Vertical") * moveSpeed *Time.deltaTime)); 
			isMoving = true;
			lastMove = new Vector2 (0, Input.GetAxisRaw ("Vertical")); 
		}
		anim.SetFloat ("MoveX", Input.GetAxisRaw ("Horizontal"));
		anim.SetFloat ("MoveY", Input.GetAxisRaw ("Vertical"));
		anim.SetBool("isMoving", isMoving);
		anim.SetFloat ("LastMoveX", lastMove.x);
		anim.SetFloat ("LastMoveY", lastMove.y);

	}
}
