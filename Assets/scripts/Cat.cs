using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour {

	public GameObject cat_apple;
	public bool isFeed=false;//false da no

	// Use this for initialization
	void Start () {
		isFeed = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void VisibleApple(){
		cat_apple.GetComponent<MeshRenderer>().enabled = false;
	}
}
