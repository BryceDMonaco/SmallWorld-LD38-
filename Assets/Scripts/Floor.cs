/*
 *	Author: Bryce Monaco
 *	Last Updated: 4/22/2017
 *
 *	Description: Handles the player staying in bounds
 *
 *	TODO: Create central game controller that reports to other scripts when game is over.
 *
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour 
{
	public GameObject gameoverText;
	public bool gameover = false;

	void Start () 
	{
		
	}
	
	void Update () 
	{
		
	}

	void OnTriggerExit2D (Collider2D col)
	{
		if (!gameover && col.CompareTag("Player")) 
		{
			gameover = true;
			gameoverText.SetActive (true);

		}

	}
}
