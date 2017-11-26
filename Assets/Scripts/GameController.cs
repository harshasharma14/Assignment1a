//					 COMP3064 CRN13899 Assignment 1
//                   Submitted to: Przemyslaw Pawluk
//                      Sunday, November 26, 2017        
//                   From: Harsha Sharma  - 101039753 
//                	 harsha.sharma@georgebrown.ca

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//acssess to UI
using UnityEngine.UI;
//starting scene when push the restart botton 
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	//add variable to UI
	[SerializeField] 
	Text life;
	[SerializeField] 
	Text score;
	[SerializeField]
	Text gameOver;
	[SerializeField]
	Text highScore;
	[SerializeField]
	Button reset;
	[SerializeField]
	GameObject bird;
	//adding variable
	private int gameScore; 
	public int lifeGame;
	public int gameHighScore;
	public int a;

	//public property 
	public int Score{
		get{ return gameScore; }
		set{gameScore = value;
			//update UI
			score.text = "Score: " + gameScore;

			gameHighScore = gameScore;

			highScore.text = "Score: " + gameHighScore;
		}

	}
		

	public void updateUI (){


	}



	public int Life{
		get{ return lifeGame; }
		set{ lifeGame = value;
			if (lifeGame <= 0) {GameOver();
			}else{life.text = "Life: " + lifeGame;
			}
		}
	}
	//make game over and restart disappear
	private void initialize(){

		Score = 0;
		Life = 5;

		gameOver.gameObject.SetActive (false);
		highScore.gameObject.SetActive (false);
		reset.gameObject.SetActive (false);
		life.gameObject.SetActive (true);
		score.gameObject.SetActive (true);
		bird.SetActive (true);
	}

	public void GameOver(){
		Time.timeScale = 0;
		gameOver.gameObject.SetActive (true);
		highScore.gameObject.SetActive (true);
		reset.gameObject.SetActive (true);
		life.gameObject.SetActive (false);
		score.gameObject.SetActive (false);
		bird.SetActive (false);
	}

	// Use this for initialization
	void Start () {
		initialize ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void ResetBtnClick(){

		SceneManager.
		LoadScene (
			SceneManager.GetActiveScene ().name);

	}

}


