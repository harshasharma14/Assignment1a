//					 COMP3064 CRN13899 Assignment 1
//                   Submitted to: Przemyslaw Pawluk
//                      Sunday, November 26, 2017        
//                   From: Harsha Sharma  - 101039753 
//                	 harsha.sharma@georgebrown.ca

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour {

	//speed variables
	[SerializeField]
	float minXSpeed = 5f;
	[SerializeField]
	float maxXSpeed = 10f;
	[SerializeField]
	float minYSpeed = -2f;
	[SerializeField]
	float maxYSpeed = 2f;

	//private Variables
	private Transform _transform;
	private Vector2 _currentSpeed;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		Reset ();

	}

	public void Reset(){
		//decide spped and range of enemy
		float xSpeed = Random.Range (minXSpeed, maxXSpeed);
		float ySpeed = Random.Range (minYSpeed, maxYSpeed);

		_currentSpeed = new Vector2 (xSpeed, ySpeed);

		float y = Random.Range (-4.12f, 4.12f);
		_transform.position = new Vector2 (7 + Random.Range (0, 3), y);
	}

	// Update is called once per frame
	void Update () {
		_currentPosition = _transform.position;
		_currentPosition -= _currentSpeed;
		_transform.position = _currentPosition;

		if (_currentPosition.x <= -8) {
			Reset ();
		}
	}
}
