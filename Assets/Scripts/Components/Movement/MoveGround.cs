using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DudeController))]
public class MoveGround : MonoBehaviour {

	private Rigidbody2D body;
	private DudeController controller;

	public float speed = 8;

	void Awake() {
		body = GetComponent<Rigidbody2D>();
		controller = GetComponent<DudeController>();
	}

	void Update () {
		Vector2 input = controller.input;

		float speedX = body.velocity.x;
		float speedY = body.velocity.y;

		if (input.x != 0) {
			speedX = input.x * speed;
		}

		if (input.y != 0) {
			speedY = input.y * speed * 0.75f;
		}

		body.velocity = new Vector2(speedX, speedY);
	}
}
