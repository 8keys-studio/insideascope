using UnityEngine;
using System.Collections;

public class darkEnd : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "MainCamera") {
			Debug.Log ("heart collided");
			Application.LoadLevel ("BadEndDark");
		}
	
	}
	
	}

