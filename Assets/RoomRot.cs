using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomRot : MonoBehaviour {

	private float velx = 0.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (UnityStandardAssets.Characters.FirstPerson.FirstPersonController.rot) {
			float rot = -1 * Time.deltaTime * 10;
			transform.Rotate(rot, 0, 0);
		} else if (UnityStandardAssets.Characters.FirstPerson.FirstPersonController.manualrot) {
			float newx = Mathf.SmoothDamp(transform.eulerAngles.x, UnityStandardAssets.Characters.FirstPerson.FirstPersonController.rotdeg.x, ref velx, 1);
			transform.eulerAngles = new Vector3 (newx, 0, 0);
		}
	}
}
