using UnityEngine;
using System.Collections;

public class openingStoryScript : MonoBehaviour {

	// on start, disable player controls
	//shows canvas and plays voiceover
	// after timer, thisobject disables and player controls fully enabled

	private GameObject playerObject;
	private float timer;
	public float timerLength;
	private bool playerEnabled;

	void Awake() {
		playerObject = GameObject.FindWithTag("Player");
	}

	void Update() {
		Debug.Log ("timer =" + timer);
		//start timer

		//disable playerObject
		if (timer < timerLength) {
			timer += Time.time;
			playerEnabled = false;
			playerObject.active = false;
		} else {
			playerEnabled = true;
			playerObject.active = true;
			gameObject.active = false;
		}
		//play voiceover
	}

}
