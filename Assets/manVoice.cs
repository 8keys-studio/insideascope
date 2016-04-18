using UnityEngine;
using System.Collections;

public class manVoice : MonoBehaviour {

	public AudioClip clip;


	void OnTriggerEnter(Collider other) {

		if (other.tag == "Player"){
		
		AudioSource.PlayClipAtPoint(clip, transform.position);

	}
}
