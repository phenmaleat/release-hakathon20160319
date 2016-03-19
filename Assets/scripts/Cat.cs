using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour {

	public GameObject cat_apple;
	public bool isFeed=false;//false da no
	public float currentCountdownTimeInSecond = 0f;
	public int randomForCountDown = 0;

	// Use this for initialization
	void Start () {
		isFeed = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isFeed) {
			if (Time.fixedTime - currentCountdownTimeInSecond > randomForCountDown) {
				isFeed=false;
				cat_apple.GetComponent<MeshRenderer>().enabled = true;
				MeshRenderer[] components =  cat_apple.GetComponentsInChildren<MeshRenderer>();

				for (int i = 0; i < components.Length; i++) {
					components [i].enabled = true;
				}
			}
		}
	}
}
