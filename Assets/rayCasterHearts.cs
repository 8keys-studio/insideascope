using UnityEngine;
using System.Collections;

public class rayCasterHearts : MonoBehaviour {

	public float rayDistance = 100f;
	public LayerMask Hearts;


	void Update(){
		RaycastHit hit;
		if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance, Hearts))
			Debug.Log ("I've just hit " + hit.collider.gameObject.name);
//		if (Input.GetMouseButtonDown(0)`) {
//			Application.LoadLevel(");
//		}
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		//Debug.DrawLine(ray.origin, hit.point);
	}

	void OnGizmosDraw(){
		Gizmos.color = Color.red;
		Gizmos.DrawRay (transform.position, transform.forward * rayDistance);
	}

}
