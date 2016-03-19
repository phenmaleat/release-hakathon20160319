using UnityEngine;
using System.Collections;

public class Apple : MonoBehaviour {
	public GameObject apple;
	public GameObject user_apple;
	public GameObject cat;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		print("cham vao qua tao");

		if (apple.GetComponent<MeshRenderer> ().enabled == true) {
			apple.GetComponent<MeshRenderer> ().enabled = false;
			user_apple.GetComponent<MeshRenderer>().enabled = true;

		}

	}
}
