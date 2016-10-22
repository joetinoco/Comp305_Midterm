using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public int enemyCount;
	public GameObject enemy;

	// PRIVATE INSTANCE VARIABLES
	private int _score;
	private int _hullPoints;
	
	// Use this for initialization
	void Start () {
		this._GenerateEnemies ();
		this._score = 0;
		this._hullPoints = 5;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Allow update of game score by other objects
	public void updateScore(int delta){ 
		this._score += delta;
		Debug.Log("Score: " + this._score);
	}

	// Allow update of hull points by other objects
	public void updateHullPoints(int delta){ 
		this._hullPoints += delta;
		Debug.Log("Hull points: " + this._hullPoints);
	}

	// generate Clouds
	private void _GenerateEnemies() {
		for (int count=0; count < this.enemyCount; count++) {
			Instantiate(enemy);
		}
	}
}
