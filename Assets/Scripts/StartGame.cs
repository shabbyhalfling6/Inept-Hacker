﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartGame : MonoBehaviour {
	
	void Update ()
    {
	    if(Input.GetKeyDown(KeyCode.Return))
            SceneManager.LoadScene(1);
	}
}
