using UnityEngine;
using System.Collections;

public class manVoice : MonoBehaviour {

	public AudioClip clip;
	private bool alreadyPlayed = false;


	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player" && !alreadyPlayed) {
			AudioSource.PlayClipAtPoint (clip, transform.position);
			alreadyPlayed = true;
			Rigidbody rb = GetComponent<Rigidbody>();
			Vector3 randomDirection = new Vector3(Random.value, 5.0F, Random.value);
			rb.AddRelativeTorque(randomDirection);
			rb.velocity = randomDirection;
		}
	}
}
