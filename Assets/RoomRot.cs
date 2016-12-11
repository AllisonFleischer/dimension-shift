using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomRot : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (UnityStandardAssets.Characters.FirstPerson.FirstPersonController.rot) {
			float rot = -1 * Time.deltaTime * 10;
			transform.Rotate(rot, 0, 0);
		}
	}
}
