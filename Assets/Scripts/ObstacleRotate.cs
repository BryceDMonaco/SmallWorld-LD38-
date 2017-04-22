/*
 *	Author: Bryce Monaco
 *	Last Updated: 4/22/2017
 *
 *	Description: A simple script which orbits the object around the planet
 *
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotate : MonoBehaviour 
{
	public float speed = 1f;
	private Rigidbody2D myRB;

	void Start () 
	{
		myRB = GetComponent<Rigidbody2D> ();

	}

	void FixedUpdate ()
	{
		transform.Rotate (new Vector3 (0, 0, speed));

	}
}
