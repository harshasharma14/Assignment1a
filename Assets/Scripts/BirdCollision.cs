//					 COMP3064 CRN13899 Assignment 1
//                   Submitted to: Przemyslaw Pawluk
//                      Sunday, November 26, 2017        
//                   From: Harsha Sharma  - 101039753 
//                	 harsha.sharma@georgebrown.ca

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCollision : MonoBehaviour {


	[SerializeField] GameController gameController;

	[SerializeField] GameObject explosion;

	private GameController _canvasController;
	private AudioSource _coinSound;
	[SerializeField] AudioClip coinAudioClip;

	// Use this for initialization
	void Start () {
		_coinSound = gameObject.GetComponent<AudioSource> ();
		_canvasController = gameObject.GetComponent<GameController> ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void OnTriggerEnter2D(Collider2D other){


		if (other.gameObject.tag == "coin") {
			Debug.Log ("Collision w coin\n");
			if (_coinSound != null) {
				_coinSound.PlayOneShot (coinAudioClip);
			}
			//Destroy (other.gameObject);
			//Adding points
			gameController.Score += 100;
			other.gameObject.GetComponent<CoinController> ().Reset();

		} else if (other.gameObject.tag == "bomb") {
			Debug.Log ("Collision w bomb\n");

			//decreasing life after collision with enemy;
			gameController.Life -= 1;

			var expl = Instantiate (explosion);

			expl.GetComponent<Transform> ()
				.position = other.gameObject
					.GetComponent<Transform> ()
					.position;
			Destroy (expl, 0.5f);
			//enemy will disappear after collision
			other.gameObject.GetComponent<BombController> ().Reset ();

		} else if (other.gameObject.tag == "bomb") { 
			Debug.Log ("Collision w bomb\n");

			gameController.Life -= 1;

			var expl = Instantiate (explosion);

			expl.GetComponent<Transform> ()
				.position = other.gameObject
					.GetComponent<Transform> ()
					.position;
			Destroy (expl, 0.5f);

			other.gameObject.
			GetComponent<BombController> ().Reset ();

		}

	}
}
