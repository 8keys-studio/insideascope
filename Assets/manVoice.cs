using UnityEngine;
using System.Collections;

public class manVoice : MonoBehaviour {

	public AudioClip clip;
	private bool alreadyPlayed = false;


	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player" && !alreadyPlayed) {
			AudioSource.PlayClipAtPoint (clip, transform.position);
			alreadyPlayed = true;
		}
	}
}
