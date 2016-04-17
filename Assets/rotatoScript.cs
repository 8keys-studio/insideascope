using UnityEngine;
using System.Collections;

public class rotatoScript : MonoBehaviour {
	public float speed = 1.0F;
	public float scale = 1.0F;
	private float scaleMin = 10.0F;
	private float scaleMax = 250.0F;

	void LateUpdate (){
		transform.RotateAround(transform.position, Vector3.up, (0.2F + Input.acceleration.x) * speed);
		foreach (Transform child in transform) {
			float scaleX = accelerate(child.transform.localScale.x, Input.acceleration.x);
			float scaleY = accelerate(child.transform.localScale.y, Input.acceleration.y);
			float scaleZ = accelerate(child.transform.localScale.z, Input.acceleration.z);
			child.transform.localScale = new Vector3 (scaleX, scaleY, scaleZ);
			Rigidbody rb = child.GetComponent<Rigidbody>();
			Vector3 randomDirection = new Vector3(Random.value, Random.value, Random.value);
			rb.AddRelativeTorque(randomDirection * 0.1F);
		}
	}

	float accelerate(float initial, float accelAxis) {
		return Mathf.Clamp((initial + accelAxis * scaleMax * Random.value), scaleMin, scaleMax);
	}

	float randomAccelerationAxis() {
		float[] accel = new float[] { Input.acceleration.x, Input.acceleration.y, Input.acceleration.z };
		return accel[Random.Range (0, accel.Length - 1)];
	}
}
