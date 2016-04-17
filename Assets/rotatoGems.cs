using UnityEngine;
using System.Collections;

public class rotatoGems : MonoBehaviour {

	public float speed;

	void Update (){
		transform.RotateAround(transform.position, Vector3.up, speed * Time.deltaTime);
	}
}