﻿using UnityEngine;
using System.Collections;

public class KillZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other){
        //soundManager.AudioSource.Play(); death sound or something
		Destroy (other.gameObject);
	}
}
