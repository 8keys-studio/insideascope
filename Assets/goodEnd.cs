using UnityEngine;
using System.Collections;

public class goodEnd : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "MainCamera") {
			Debug.Log ("heart collided");
			Application.LoadLevel ("GoodEnd");
		}
	
	}
	
	}

