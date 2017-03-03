using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject target;

	float timeToMove = 0.25f;

	void Start () {
		if (target != null) {
			MoveCameraTowardsTarget(timeToMove);
		}
	}

	void Update () {
		if (target != null) {
			MoveCameraTowardsTarget(Time.deltaTime);
		}
	}

	private void MoveCameraTowardsTarget(float delta) {
		float x = transform.position.x;
		float y = transform.position.y;
		float xd = target.transform.position.x - x;
		float yd = target.transform.position.y - y;
		float pc = delta / timeToMove;
		transform.position = new Vector3(x + xd * pc, y + yd * pc, transform.position.z);
	}
}
