using UnityEngine;
using System.Collections;

public class MasterObject : MonoBehaviour {
	
	public Transform sphere;
	public float turnSpeed = 45.0f;
	public float moveSpeed = 45.0f;
	private Transform center;
	
	void Start () {
		
		center = new GameObject().transform;
		center.parent = sphere;
		transform.parent = center;
	}
	
	void Update() {
		
//		if (Input.GetKey(KeyCode.LeftArrow)) {
//			transform.Rotate (0.0f, -turnSpeed * Time.deltaTime, 0.0f);        
//		}
//		if (Input.GetKey(KeyCode.RightArrow)) {
//			transform.Rotate (0.0f, turnSpeed * Time.deltaTime, 0.0f);        
//		}
	    if (Input.GetKey (KeyCode.RightArrow)) {
			Vector3 v3Axis = -Vector3.Cross (center.position - transform.position, transform.forward);
			center.rotation = Quaternion.AngleAxis(moveSpeed    * Time.deltaTime, v3Axis) * center.rotation;
		}
		else if (Input.GetKey (KeyCode.LeftArrow)) {
			Vector3 v3Axis = Vector3.Cross (center.position - transform.position, transform.forward);
			center.rotation = Quaternion.AngleAxis(moveSpeed * Time.deltaTime, v3Axis) * center.rotation;
		}else if (Input.GetKey (KeyCode.UpArrow)) {
			Vector3 v3Axis = -Vector3.Cross (center.position - transform.position, transform.up);
			center.rotation = Quaternion.AngleAxis(moveSpeed    * Time.deltaTime, v3Axis) * center.rotation;
		}else if (Input.GetKey (KeyCode.DownArrow)) {
			Vector3 v3Axis = Vector3.Cross (center.position - transform.position, transform.up);
			center.rotation = Quaternion.AngleAxis(moveSpeed    * Time.deltaTime, v3Axis) * center.rotation;
		}
	}
}