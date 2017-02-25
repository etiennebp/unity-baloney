using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Animator animator;
	private SpriteRenderer renderer;

	void Start () {
		animator = GetComponent<Animator>();
		renderer = GetComponent<SpriteRenderer>();
	}

	void Update () {
		int directionX = 0;
		if (Input.GetKey(KeyCode.A)) directionX--;
		if (Input.GetKey(KeyCode.D)) directionX++;

		if (directionX != 0) {
			renderer.transform.localScale = new Vector3(directionX, 1);
			animator.SetBool("running", true);
		}
		else {
			animator.SetBool("running", false);
		}
	}
}
