using UnityEngine;

public class OrderByPosition : MonoBehaviour {

	private SpriteRenderer spriteRenderer;

	void Awake() {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	void LateUpdate() {
		spriteRenderer.sortingOrder = -(int)Mathf.Floor(transform.position.y * 10);
	}
}