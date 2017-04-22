/*
 *	Author: Bryce Monaco
 *	Last Updated: 4/22/2017
 *
 *	Description: Spawns obstacles
 *
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour 
{
	public GameObject block;
	public float spawnTimeMin = 3f;
	public float spawnTimeMax = 6f;
	private float nextSpawnAtTime;

	void Start () 
	{
		GenerateSpawnTime ();
	}
	
	void Update () 
	{
		if (nextSpawnAtTime <= Time.time)
		{
			GameObject myBlock = Instantiate (block, transform.position, Quaternion.Euler (new Vector3 (0, 0, -45)));
			GameObject.Destroy (myBlock, 5f);

			GenerateSpawnTime ();

		}

	}

	void GenerateSpawnTime ()
	{
		nextSpawnAtTime = Time.time + Random.Range (spawnTimeMin, spawnTimeMax);

	}
}
