using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DudeController))]
public class InputWander : MonoBehaviour {

	private DudeController controller;

	private float direction;

	private bool walk;
	private float timeTillToggle;

	void Awake() {
		controller = GetComponent<DudeController>();

		walk = Random.value >= 0.5;
		SetNextAction();
	}

	void Update () {
		timeTillToggle -= Time.deltaTime;
		if (timeTillToggle <= 0) {
			SetNextAction();
		}

		if (walk) {
			WalkLikeARetard();
		}

	}

	private void SetNextAction() {
		timeTillToggle = Random.Range(0.5f, 2f);
		walk = !walk;

		// reset
		controller.input = new Vector2();
		direction = Random.Range(0f, 360f);
	}

	private void WalkLikeARetard() {
		direction += Random.Range(-20f, 20f);
		direction = (direction + 360) % 360;
		float rad = direction * Mathf.Deg2Rad;
		controller.input = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));
	}
}
