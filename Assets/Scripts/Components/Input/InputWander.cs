using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DudeController))]
public class InputWander : MonoBehaviour {

	private DudeController controller;

	private float direction = Random.Range(0f, 360f);

	void Awake() {
		controller = GetComponent<DudeController>();
	}

	void Update () {
		direction += Random.Range(-20f, 20f);
		direction = (direction + 360) % 360;
		controller.input = new Vector2(Mathf.Cos(direction * Mathf.Deg2Rad), Mathf.Sin(direction * Mathf.Deg2Rad));
	}
}
