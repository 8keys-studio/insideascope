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
			gameObject.SetActive(false);
			nextCameraObject.SetActive(true);
		}
	}

}
