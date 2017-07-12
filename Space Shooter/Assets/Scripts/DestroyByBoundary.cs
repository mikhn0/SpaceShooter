using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour {

	void OnTriggerEnter( Collider other )
	{
		print ("OnTriggerEnter");
	}

	void OnTriggerExit(Collider other) {
		print ("OnTriggerExit");
		Destroy(other.gameObject);
	}
}
