using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		foreach(Touch touch in Input.touches){
			Debug.Log ("tch");

			if (touch.phase == TouchPhase.Began) {
				Debug.Log ("tch1 Began");
			}
		}
	}
}
