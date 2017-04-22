/*
 *	Author: Bryce Monaco
 *	Last Updated: 4/21/2017
 *
 *	Description: This script handles all player controls
 *
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	public float jumpForce = 10;
	public bool grounded = false;

	private Rigidbody2D myRB;

	void Start () 
	{
		myRB = GetComponent<Rigidbody2D> ();

		if (myRB == null)
		{
			Debug.Log ("ERROR: " + gameObject.name + " missing RB2D!");

		}
		
	}
	
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Space) && grounded)
		{
			myRB.AddForce (Vector2.up * jumpForce);

		}

	}

	void FixedUpdate ()
	{
		

	}

	void OnCollisionEnter2D (Collision2D col)
	{
		Debug.Log ("Touched");

		if (col.gameObject.CompareTag("Respawn"))
		{
			grounded = true;

		}

	}

	void OnCollisionExit2D (Collision2D col)
	{
		Debug.Log ("Left");

		if (col.gameObject.CompareTag("Respawn"))
		{
			grounded = false;

		}

	}
}
