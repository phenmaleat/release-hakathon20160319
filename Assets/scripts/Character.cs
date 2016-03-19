using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	public GameObject cat;
	public GameObject user_apple;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		print("cham vao thang nguoi");

		if (user_apple.GetComponent<MeshRenderer> ().enabled == true) {
			user_apple.GetComponent<MeshRenderer> ().enabled = false;
			if (cat.GetComponent<Cat> ().isFeed == false) {
				cat.GetComponent<Cat> ().isFeed = true;
				cat.GetComponent<Cat> ().VisibleApple ();
			}
		}

	}
}
