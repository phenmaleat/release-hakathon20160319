using UnityEngine;
using System.Collections;

public class MasterEarth : MonoBehaviour {
	Vector2 delta;
	float moveSpeed = 80f;
	public Transform earth;
	void Start(){
	}
	void OnMouseDrag ()
	{
//		print (delta.x);
//		print (delta.y);
		Vector3 v3Axis = -earth.up*delta.x;
		earth.rotation = Quaternion.AngleAxis(moveSpeed * Time.deltaTime,v3Axis) * earth.rotation;

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
