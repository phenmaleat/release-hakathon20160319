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
		
		if (gameObject.tag == "cube_center") {
			if (other.gameObject.tag == "syc_TreeFromTutorial") {
				print ("cay vao cho mua");
				other.gameObject.GetComponent<Apple> ().apple.GetComponent<MeshRenderer>().enabled = true;
			
			}
		}
	}


}
