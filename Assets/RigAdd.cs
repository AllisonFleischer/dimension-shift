using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigAdd : MonoBehaviour {

	private bool physicsActive = false;
	private bool frozen = false;
	private Rigidbody sc;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if ((UnityStandardAssets.Characters.FirstPerson.FirstPersonController.startphysics) && (physicsActive == false)) {
			sc = gameObject.AddComponent<Rigidbody>() as Rigidbody;
			physicsActive = true;
		}
		if ((UnityStandardAssets.Characters.FirstPerson.FirstPersonController.freeze) && (frozen == false)) {
			sc.isKinematic = true;
			frozen = true;
		}
	}
}
