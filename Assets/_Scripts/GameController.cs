using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*

GameController
---------------

by Joseph Tinoco - 300819835
Last modified - Oct 22, 2016

Handles player lives, scores and game flow

*/

public class GameController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public int enemyCount;
	public GameObject enemy;
	public Text scoreText;
	public Text highScoreText;
	public Text hullPointsText;
	public Button btnRestart;
	public bool gameOver = false;

	// PRIVATE INSTANCE VARIABLES
	private int _score;
	private int _highScore;
	private int _hullPoints;
	
	// Use this for initialization
	void Start () {
		this._GenerateEnemies ();
		this._score = 0;
		this._hullPoints = 5;
		this.highScoreText.gameObject.SetActive(false);
		this.btnRestart.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (!gameOver){
			scoreText.text = "Score: " + this._score;
			highScoreText.text = "High score: " + this._highScore;
			hullPointsText.text = "Hull points: " + this._hullPoints;
		}
	}

	// Allow update of game score by other objects
	public void updateScore(int delta){ 
		this._score += delta;
		if (_score > _highScore) _highScore = _score;
		Debug.Log("Score: " + this._score);
	}

	// Allow update of hull points by other objects
	public void updateHullPoints(int delta){ 
		this._hullPoints += delta;
		if (this._hullPoints == 0) {
			gameOver = true;
			this.highScoreText.gameObject.SetActive(true);
			this.btnRestart.gameObject.SetActive(true);
		} else Debug.Log("Hull points: " + this._hullPoints);
	}

	// generate Clouds
	private void _GenerateEnemies() {
		for (int count=0; count < this.enemyCount; count++) {
			Instantiate(enemy);
		}
	}

	// Handler for the restart button
	public void RestartButton_Click() {
 		SceneManager.LoadScene ("Main");
 	}
}
