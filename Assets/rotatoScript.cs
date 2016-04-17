using UnityEngine;
using System.Collections;

public class rotatoScript : MonoBehaviour {

	public float speed = 5f;
	public GameObject gemParent;
	private Vector3 rotationDirection;

	void Update (){
		 rotationDirection = new Vector3(0, 1, 0);
		 gemParent = gemParent.transform.parent;
		 gemParent.transform.Rotate((rotationDirection * Time.deltaTime * speed));
	
	}
}
