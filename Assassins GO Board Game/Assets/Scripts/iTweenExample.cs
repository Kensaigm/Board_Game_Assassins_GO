using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iTweenExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
		iTween.RotateTo(gameObject, iTween.Hash("y", 90f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
