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

public class Player {

	//static variable

	private int _score = 0;
	private int _life = 5;


	static private Player _instance;
	static public Player Instance{
		get{
			if (_instance == null) {
				_instance = new Player ();
			}
			return _instance;
		}	

	}
	private Player(){
	

	}
	public GameController gCtrl;


	public int Highscore {
		get{ return _score; }
		set {
			_score = value; 
			gCtrl.updateUI ();
		}
	}


	//determines score and value\
	public int Score {
		get{ return _score; }
		set{ 
			_score = value;
			//scoreLabel.text = "Score: " + _score;
			gCtrl.updateUI();
		}
	}

	//determines life and gameover
	public int Life{
		get{ return _life;}
		set{ 
			_life = value;

			if (_life <= 0) {
				//Lost game
				gCtrl.GameOver();
			}else {
				//lifeLabel.text = "Life: " + _life;
				gCtrl.updateUI();
			}
		}
			
	

	}



}
