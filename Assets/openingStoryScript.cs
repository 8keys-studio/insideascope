using UnityEngine;
using System.Collections;

public class openingStoryScript : MonoBehaviour {
	private float timer;
	private bool introCompleted = false;
	public float timerLength;

	void Update() {
		if (!introCompleted) {
			if (timer < timerLength) {
				timer += Time.time;
			} else {
				Autowalk autowalk = GetComponent<Autowalk> ();
				autowalk.enabled = true;
				introCompleted = true;
			}
		}
	}
}
