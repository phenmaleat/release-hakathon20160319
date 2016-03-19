using UnityEngine;
using System.Collections;

public class CubeCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("object" + other.gameObject.tag);
		Debug.Log ("cube" + gameObject.tag);

	}


}
