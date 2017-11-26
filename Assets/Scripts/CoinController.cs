//					 COMP3064 CRN13899 Assignment 1
//                   Submitted to: Przemyslaw Pawluk
//                      Sunday, November 26, 2017        
//                   From: Harsha Sharma  - 101039753 
//                	 harsha.sharma@georgebrown.ca

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

	//public
	[SerializeField]
	private float speed = 3f;
	[SerializeField]
	private float startX;
	[SerializeField]
	private float endX;
	[SerializeField]
	private float startY;
	[SerializeField]
	private float endY;

	//private
	private Transform _transform;
	private Vector2 _currentPos;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		_currentPos = _transform.position;
		Reset ();

	}

	// Update is called once per frame
	void Update ()
	{
		_currentPos = _transform.position;

		_currentPos -= new Vector2 (speed, 0);

		if (_currentPos.x < endX) {

			Reset ();

		}

		_transform.position = _currentPos;
	}

	public void Reset(){
		//how the coin loads for each frame
		float x = Random.Range (10.2f, -10.7f);
		float dy = Random.Range (6, 0);
		_currentPos = new Vector2 (x, startY+dy);
	}
}
