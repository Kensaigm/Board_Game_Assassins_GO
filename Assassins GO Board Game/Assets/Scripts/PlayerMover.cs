﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {

	public Vector3 destination;
	public bool isMoving = false;
	public iTween.EaseType easeType = iTween.EaseType.easeInOutExpo;

	public float moveSpeed = 1.5f;
	public float iTweenDelay = 0f;


	// Use this for initialization
	void Start () {
		// Testing here
		Move(new Vector3(2f, 0f, 0f), 1f);
		Move(new Vector3(4f, 0f, 0f), 3f);
		Move(new Vector3(4f, 0f, 2f), 5f);
		Move(new Vector3(4f, 0f, 4f), 7f);
		// End testing
	}

	public void Move(Vector3 destinationPos, float delayTime = 0.25f )
	{
		StartCoroutine(MoveRoutine(destinationPos, delayTime));
	}

	IEnumerator MoveRoutine(Vector3 destinationPos, float delayTime)
	{
		isMoving = true;
		yield return new WaitForSeconds(delayTime);
		iTween.MoveTo(gameObject, iTween.Hash(
			"x", destinationPos.x,
			"y", destinationPos.y,
			"z", destinationPos.z,
			"delay", iTweenDelay,
			"easetype", easeType,
			"speed", moveSpeed
		));

		while(Vector3.Distance(destinationPos, transform.position) > 0.01f)
		{
			yield return null;
		}

		iTween.Stop(gameObject);
		transform.position = destinationPos;
		isMoving = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
