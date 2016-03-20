using UnityEngine;
using System.Collections;

public class HideVictoryMask : MonoBehaviour {

	public GameObject catObj;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown (){
//		gameObject.GetComponent<MeshRenderer> ().enabled = false;
		catObj.GetComponent<Character> ().reset ();
	}
}
