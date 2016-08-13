using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {


	// Use this for initialization
	void Start () {

		this.transform.rotation = Random.rotation;

	
	}
	
	// Update is called once per frame
	 void Update () {
		
		this.transform.Rotate(Vector3.right * Time.deltaTime* (Random.Range(10f, 20f)));


	
	}

	public void OnMouseDown(){
		// this object was clicked - do something
				transform.localScale += new Vector3(1.0f,1.0f,1.0f)*Time.deltaTime;
	}
}
