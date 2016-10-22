using UnityEngine;
using System.Collections;

/*

PlayerCollider
---------------

by Joseph Tinoco - 300819835
Last modified - Oct 22, 2016

Check for collisions with enemies

*/

public class PlayerCollider : MonoBehaviour {

		// PRIVATE INSTANCE VARIABLES
		private GameController gameController;

		// Object initialization
		void Start () {
			this.gameController = GameObject
					.FindGameObjectWithTag("GameController")
					.GetComponent<GameController>();
		}

		// Treats enemy collisions with player
		private void OnTriggerEnter2D(Collider2D other) {
			gameController.updateHullPoints(-1);
			other.gameObject.SendMessage("reset");
		}

}
