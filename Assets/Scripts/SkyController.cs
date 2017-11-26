//					 COMP3064 CRN13899 Assignment 1
//                   Submitted to: Przemyslaw Pawluk
//                      Sunday, November 26, 2017        
//                   From: Harsha Sharma  - 101039753 
//                	 harsha.sharma@georgebrown.ca

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyController : MonoBehaviour {

	//Seralized variables
	[SerializeField]
	private float speed = 1f;
	[SerializeField]
	private float startX;
	[SerializeField]
	private float endX;

	//private variables
	private Transform _transform;
	private Vector2 _currentPos;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		_currentPos = _transform.position;
		Reset ();

	}

	// Update is called once per frame
	void Update () {
		_currentPos = _transform.position;

		//move street
		_currentPos -= new 	Vector2 (speed,0);

		//check the reset
		if (_currentPos.x < endX) {
			Reset ();
		}
		//applying changes
		_transform.position = _currentPos;


	}

	private void Reset(){

		_currentPos = new Vector2 (startX, 0);
	}
}
