using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	public GameObject user_apple;
	public GameObject cat_apple;
	public GameObject[] apple_reds;
	public GameObject[] apple_blues;

	public GameObject victory_mask;
	public int MAX_SCORE = 3;
	private int score = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int i;
		if (score > 0 && score < MAX_SCORE) {
			
			for (i = 0; i < score; i++) {
				apple_reds [i].GetComponent<MeshRenderer> ().enabled = true;
				apple_blues [i].GetComponent<MeshRenderer> ().enabled = false;
			}

			for (i = MAX_SCORE - 1; i >= score; i--) {
				apple_reds [i].GetComponent<MeshRenderer> ().enabled = false;
				apple_blues [i].GetComponent<MeshRenderer> ().enabled = true;
			}

		} else if (score == 0) {
			for (i = 0; i < MAX_SCORE; i++) {
				apple_reds [i].GetComponent<MeshRenderer> ().enabled = false;
				apple_blues [i].GetComponent<MeshRenderer> ().enabled = true;
				victory_mask.SetActive (false);
			}
		} else if (score == MAX_SCORE) {
			victory_mask.SetActive (true);
		}
	}

	void OnMouseDown()
	{
		print("cham vao con meo");

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
				int i;
				for (i = 0; i < components.Length; i++) {
					components [i].enabled = false;
				}

				score++;


			}
		}

	}


	public void reset()
	{
		score = 0;
	}
}

