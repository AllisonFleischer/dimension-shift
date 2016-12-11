using UnityEngine;
using System.Collections;

public class LightMod : MonoBehaviour {
	public Light lt;
	void Start() {
		lt = GetComponent<Light>();
	}
	void Update() {
		lt.color = UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController.c;
	}
}
