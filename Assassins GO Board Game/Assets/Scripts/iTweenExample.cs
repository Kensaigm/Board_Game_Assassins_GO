using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iTweenExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
		iTween.RotateTo(gameObject, iTween.Hash("y", 90f, "delay", 1f, "time", 2f, "easetype", iTween.EaseType.easeInOutExpo));

		iTween.RotateTo(gameObject, iTween.Hash(
			"x", 90f,
			"delay", 2f,
			"time", 1f,
			"easetype", iTween.EaseType.easeInBounce
		));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
