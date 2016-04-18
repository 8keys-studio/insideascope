using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class manVoice : MonoBehaviour {

	public AudioClip clip;
	public AudioClip music;
	private bool alreadyPlayed = false;


	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player" && !alreadyPlayed) {
			cueLineTakeOffThenMusic ();
		}
	}

	void cueLineTakeOffThenMusic() {
		AudioSource.PlayClipAtPoint (clip, transform.position, 1.0F);
		alreadyPlayed = true;
		Rigidbody rb = GetComponent<Rigidbody>();
		Vector3 randomDirection = new Vector3(Random.value, 5.0F, Random.value);
		rb.AddRelativeTorque(randomDirection);
		rb.velocity = randomDirection;
		StartCoroutine (delayMusic ());
	}

	IEnumerator delayMusic() {
		yield return new WaitForSeconds (4);
		AudioSource.PlayClipAtPoint (music, Camera.main.transform.position);
	}
}

