using UnityEngine;
using System.Collections;

public class heartGemMovement : MonoBehaviour {

	public float speed;
	public Transform target;
	public float floatSpeed;

	void Update (){
		float step = floatSpeed * Time.deltaTime;
		transform.RotateAround(transform.position, Vector3.up, speed * Time.deltaTime);
		transform.position = Vector3.MoveTowards (transform.position, target.position, step);
	}
}
