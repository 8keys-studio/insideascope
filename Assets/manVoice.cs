using UnityEngine;
using System.Collections;

public class manVoice : MonoBehaviour {


	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			AudioSource.Play();
		}
	}
}
