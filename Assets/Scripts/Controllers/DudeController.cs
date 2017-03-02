using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudeController : MonoBehaviour {

	private Animator animator;
	private SpriteRenderer renderer;

	public Vector2 input = new Vector2();

	void Awake() {
		animator = GetComponent<Animator>();
		renderer = GetComponent<SpriteRenderer>();
	}

	void LateUpdate() {
		bool running = input.x != 0 || input.y != 0;
		animator.SetBool("running", running);

		if (input.x != 0) {
			float scale = input.x < 0 ? -1 : 1;
			renderer.transform.localScale = new Vector3(scale, 1);
		}
	}
}
