using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

	public bool isTitle = true;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if ((Input.GetButtonDown("Jump")) && (isTitle)) {
			SceneManager.LoadScene("main");
		}
		if (Input.GetButtonDown("Cancel")) {
			Application.Quit();
		}
	}
}
