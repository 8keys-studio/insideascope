using UnityEngine;
using System.Collections;

public class openingStoryScript : MonoBehaviour {
	private float timer;
	public GameObject nextCameraObject;
	public float timerLength;

	void Update() {
		if (timer < timerLength) {
			timer += Time.time;
		} else {
			nextCameraObject.SetActive(true);
			gameObject.SetActive(false);
		}
	}

}
