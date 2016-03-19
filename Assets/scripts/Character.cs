using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	public GameObject user_apple;
	public GameObject cat_apple;
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
			if (gameObject.GetComponent<Cat> ().isFeed == false) {
				gameObject.GetComponent<Cat> ().isFeed = true;
				gameObject.GetComponent<Cat> ().currentCountdownTimeInSecond = Time.fixedTime;
				gameObject.GetComponent<Cat> ().randomForCountDown = Random.Range (5,10);

				print ("random " + gameObject.GetComponent<Cat> ().randomForCountDown);
				print ("current " + gameObject.GetComponent<Cat> ().currentCountdownTimeInSecond);

				cat_apple.GetComponent<MeshRenderer>().enabled = false;
				MeshRenderer[] components =  cat_apple.GetComponentsInChildren<MeshRenderer>();

				for (int i = 0; i < components.Length; i++) {
					components [i].enabled = false;
				}

			}
		}

	}
}
