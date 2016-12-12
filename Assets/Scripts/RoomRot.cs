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
		} else if (UnityStandardAssets.Characters.FirstPerson.FirstPersonController.manualrot) {
			UnityStandardAssets.Characters.FirstPerson.FirstPersonController.manualrot = false;
			StartCoroutine(RotateMe(UnityStandardAssets.Characters.FirstPerson.FirstPersonController.rotdeg, 10));
		}
	}

	IEnumerator RotateMe(Vector3 byAngles, float inTime) {
		var fromAngle = transform.rotation;
		var toAngle = Quaternion.Euler(byAngles);
		for(var t = 0f; t < 1; t += Time.deltaTime/inTime) {
			transform.rotation = Quaternion.Lerp(fromAngle, toAngle, t);
			yield return null;
		}
	}
}
