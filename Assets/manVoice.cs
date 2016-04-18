using UnityEngine;
using System.Collections;

public class manVoice : MonoBehaviour {

	public AudioClip clip;


	void OnTriggerEnter(Collider other) {
		
		AudioSource.PlayClipAtPoint(clip, transform.position);

	}
}
