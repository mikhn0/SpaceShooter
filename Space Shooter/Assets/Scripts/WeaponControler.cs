using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControler : MonoBehaviour {

	public GameObject shot;
	public Transform showSpawn;
	public float fireRate;
	public float delay;
	public AudioClip[] clips;

	private AudioSource audioSource;

	// Use this for initialization
	void Start () 
	{
		audioSource = GetComponent<AudioSource> ();
		InvokeRepeating ("Fire", delay, fireRate);
	}

	void Fire() 
	{
		Instantiate (shot, showSpawn.position, showSpawn.rotation);
		AudioClip clip = clips [Random.Range (0, clips.Length)];
		audioSource.clip = clip;
		audioSource.Play ();
	}
}
