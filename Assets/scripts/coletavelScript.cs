﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coletavelScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "player") {
			GameObject.FindGameObjectWithTag("GameController").GetComponent<PontuacaoScript> ().incrementaPontos();
			Destroy (this.gameObject);
		}
		
	}
}
