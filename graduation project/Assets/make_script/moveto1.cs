﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class moveto1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Click(){
		SceneManager.LoadScene (1);
	}
}
