using UnityEngine;
using System.Collections;

public class shadowEnd : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Debug.Log ("heart collided");
			Application.LoadLevel ("BadEndShadow");
		}
	
	}
	
	}

