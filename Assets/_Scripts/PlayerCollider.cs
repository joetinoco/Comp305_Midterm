using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

		// PRIVATE INSTANCE VARIABLES
		private GameController gameController;

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
