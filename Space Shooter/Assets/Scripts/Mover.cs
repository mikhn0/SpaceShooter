using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	[SerializeField]
	private Rigidbody rb;
	public float speed;
	void Start() {
		rb.velocity = transform.forward * speed;
	}
}
