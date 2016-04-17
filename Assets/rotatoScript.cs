using UnityEngine;
using System.Collections;

public class rotatoScript : MonoBehaviour {

	void Update (){
		transform.Rotate(Vector3.right * Time.deltaTime);
	}
}
