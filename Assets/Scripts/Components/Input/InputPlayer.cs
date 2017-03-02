using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DudeController))]
public class InputPlayer : MonoBehaviour {

	private DudeController controller;

	void Awake() {
		controller = GetComponent<DudeController>();
	}

	void Update () {
		float inputX = 0;
		if (Input.GetKey(KeyCode.A)) inputX--;
		if (Input.GetKey(KeyCode.D)) inputX++;

		float inputY = 0;
		if (Input.GetKey(KeyCode.W)) inputY++;
		if (Input.GetKey(KeyCode.S)) inputY--;

		controller.input = new Vector2(inputX, inputY);
	}
}
