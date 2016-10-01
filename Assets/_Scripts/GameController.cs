using UnityEngine;
using UnityEngine.UI; //needed for UI
using System.Collections;
using System.Collections.Generic;


public class GameController : MonoBehaviour {
    // PRIVATE INSTANCE VARIBLES++++++++++++++++++++++++

	private int _scoreValue;
	private int _livesValue =5;
	private AudioSource _gameOverSound;

	//Public instance varibles (for testing)
	public int cloudNumber = 3;
	public GameObject cloud;
	public GameObject plane;
	public GameObject island;
	public Text LivesLbl;
	public Text ScoreLbl;
	public Text GameOverLbl;
	public Text FinalScoreLbl;




	//PUBLIC VARIBLES+++++++++++++++++++++++++++++++++++
	public int ScoreValue {
		get {
			return this._scoreValue; 
		}
		set {
			this._scoreValue = value;
			this.ScoreLbl.text = "Score: " + this._scoreValue;
		}
	}
	public int LivesValue {
		get {
			return this._livesValue; 
		}
		set {
			this._livesValue = value;
			if (this._livesValue <= 0) {
				//endgame
				this._endGame ();
			} else {
				this.LivesLbl.text = "Lives: " + this._livesValue;
			}
		}
	}

	// Use this for initialization
	void Start () {
		//this._gameOverSound = this.GetComponent<AudioSource>();
		this.GameOverLbl.enabled = false;
		this.FinalScoreLbl.enabled = false;

		//this.Clouds = new List<CloudController> ();

		for (int cloudCount = 0; cloudCount < this.cloudNumber; cloudCount++) {
			
			Instantiate (this.cloud);

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
	public void _endGame() {
		//this._gameOverSound.Play();
		this.plane.SetActive (false);
		this.island.SetActive (false);
		this.GameOverLbl.enabled = true;
		this.FinalScoreLbl.text = "Final Score:" + ScoreValue;
		this.FinalScoreLbl.enabled = true;

}
}