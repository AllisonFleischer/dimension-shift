using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallShift : MonoBehaviour {
	public bool triggered = false;
	private bool shifting = false;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if ((UnityStandardAssets.Characters.FirstPerson.FirstPersonController.freeze) && (triggered == false)) {
			triggered = true;
			StartCoroutine(Shift());
		}
		if (shifting) {
			float p = transform.position.z;
			p += Time.deltaTime * 5;
			transform.position = new Vector3 (transform.position.x,transform.position.y,p);
		}
	}
	IEnumerator Shift () {
		yield return new WaitForSeconds(20f);
		shifting = true;
		yield return null;
	}
}
