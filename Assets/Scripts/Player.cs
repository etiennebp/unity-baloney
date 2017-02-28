using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Animator animator;
	private SpriteRenderer renderer;
	private Rigidbody2D body;

	private float speed = 8;

	void Start () {
		animator = GetComponent<Animator>();
		renderer = GetComponent<SpriteRenderer>();
		body = GetComponent<Rigidbody2D>();
	}

	void Update () {
		int directionX = 0;
		if (Input.GetKey(KeyCode.A)) directionX--;
		if (Input.GetKey(KeyCode.D)) directionX++;

		int directionY = 0;
		if (Input.GetKey(KeyCode.W)) directionY++;
		if (Input.GetKey(KeyCode.S)) directionY--;

		bool running = directionX != 0 || directionY != 0;
		animator.SetBool("running", running);

		float speedX = body.velocity.x;
		float speedY = body.velocity.y;

		if (directionX != 0) {
			renderer.transform.localScale = new Vector3(directionX, 1);
			speedX = directionX * speed;
		}

		if (directionY != 0) {
			speedY = directionY * speed * 0.75f;
		}

		body.velocity = new Vector2(speedX, speedY);

	}
}
