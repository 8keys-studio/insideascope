using UnityEngine;
using System.Collections;

public class rotatoScript : MonoBehaviour {
	public float speed = 1.0F;
	public float scale = 1.0F;

	void LateUpdate (){
		transform.RotateAround(transform.position, Vector3.up, (0.3F + Input.acceleration.x) * speed);
		foreach (Transform child in transform) {
			float scaleX = Mathf.Clamp((child.transform.localScale.x + Input.acceleration.x), 10.0F, 300.0F);
			float scaleY = Mathf.Clamp((child.transform.localScale.y + Input.acceleration.y), 10.0F, 300.0F);
			float scaleZ = Mathf.Clamp((child.transform.localScale.z + Input.acceleration.z), 10.0F, 300.0F);
			child.transform.localScale = new Vector3 (scaleX, scaleY, scaleZ) * (1.0F * scale);
		}
	}
}
