using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class goodEnd : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "MainCamera") {
			Debug.Log ("heart collided");
			SceneManager.LoadScene ("GoodEnd");
		}
	}
}
