using UnityEngine;
using UnityEngine.UI; //needed for UI
using System.Collections;
using System.Collections.Generic;


public class GameController : MonoBehaviour {
    // PRIVATE INSTANCE VARIBLES++++++++++++++++++++++++

	private int _scoreValue;
	private int _livesValue =5;

	//Public instance varibles (for testing)
	public int cloudNumber = 3;
	public  GameObject cloud;
	public Text LivesLbl;
	public Text ScoreLbl;




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
			this.LivesLbl.text = "Lives: " + this._livesValue;
		}
	}

	// Use this for initialization
	void Start () {

		//this.Clouds = new List<CloudController> ();

		for (int cloudCount = 0; cloudCount < this.cloudNumber; cloudCount++) {
			
			Instantiate (this.cloud);

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
}
