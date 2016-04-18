using UnityEngine;
using System.Collections;

public class darkEnd : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Application.LoadLevel ("BadEndDark");
		}
	
	}
	
	}

