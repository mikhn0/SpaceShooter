﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

	public GameObject explosion;
	public GameObject playerExplosions;
	public int scoreValue;
	private GameController gameController;

	void Start() {
		GameObject gameControllerObject = GameObject.FindWithTag("GameController");
		if (gameControllerObject != null) {
			gameController = gameControllerObject.GetComponent<GameController>();
		}

		if (gameController == null) {
			Debug.Log("Cann't find 'GameController'");
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Boundary") || other.CompareTag("Enemy")) {//(other.tag == "Boundary" || other.tag == "Enemy") {
			return;
		}

		Instantiate (explosion, transform.position, transform.rotation);

		if (other.tag == "Player") {
			Instantiate (playerExplosions, other.transform.position, other.transform.rotation);
			gameController.GameOver();
		}
		gameController.AddScore (scoreValue);
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
