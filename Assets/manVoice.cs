using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class manVoice : MonoBehaviour {

	public AudioClip clip;
	public AudioClip music;
	private bool alreadyPlayed = false;

	void OnTriggerEnter(Collider other) {
		Debug.Log (other);
		if (other.tag == "MainCamera" && !alreadyPlayed) {
			cueLineTakeOffThenMusic ();
		}
	}

//	void Update() {
//		if (Input.GetMouseButtonDown (0) && !alreadyPlayed) {
//			cueLineTakeOffThenMusic ();
//		} else if (Input.GetMouseButtonDown (0)) {
//			SceneManager.LoadScene("gem1");
//		}
//	}

	void cueLineTakeOffThenMusic() {
		AudioSource.PlayClipAtPoint (clip, transform.position, 1.0F);
		alreadyPlayed = true;
		Rigidbody rb = GetComponent<Rigidbody>();
		Vector3 randomDirection = new Vector3(Random.value, 1.0F, Random.value);
		rb.AddRelativeTorque(randomDirection);
		rb.velocity = randomDirection;
		StartCoroutine (delayMusic ());
	}

	IEnumerator delayMusic() {
		yield return new WaitForSeconds (4);
		AudioSource.PlayClipAtPoint (music, Camera.main.transform.position);
	}
}

