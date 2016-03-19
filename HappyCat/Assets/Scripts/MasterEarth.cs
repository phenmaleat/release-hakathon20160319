using UnityEngine;
using System.Collections;

public class MasterEarth : MonoBehaviour {
	Vector2 delta;
	float moveSpeed = 80f;
	void Start(){
	}
	void OnMouseDrag ()
	{
		print (delta.x);
		print (delta.y);
		Vector3 v3Axis = -transform.up*delta.x;
		transform.rotation = Quaternion.AngleAxis(moveSpeed * Time.deltaTime,v3Axis) * transform.rotation;

	}
	void OnGUI()
	{
		Event e = Event.current;
		if (e.type == EventType.MouseDrag)
		{
			delta = e.delta;
		}
	}
}
