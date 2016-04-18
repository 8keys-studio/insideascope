using UnityEngine;
using System.Collections;

public class rayCasterObelisk : MonoBehaviour {

	public float rayDistance = 100f;
	public LayerMask Obelisks;

	void Update(){
		RaycastHit hit;
		if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance, Obelisks))
			Debug.Log ("I've just hit " + hit.collider.gameObject.name);
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		//Debug.DrawLine(ray.origin, hit.point);
	}

	void OnGizmosDraw(){
		Gizmos.color = Color.red;
		Gizmos.DrawRay (transform.position, transform.forward * rayDistance);
	}

}
