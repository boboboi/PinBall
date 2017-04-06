using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour {

	private int score;

	// Use this for initialization
	void Start () {
		if (tag == "SmallStarTag") {
			score = 10;
		} else if (tag == "LargeStarTag") {
			score = 20;
		} else if (tag == "SmallCloudTag") {
			score = 30;
		} else if (tag == "LargeCloudTag") {
			score = 40;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//衝突時に呼ばれる関数
	void OnCollisionEnter(Collision other) {
		ScoreManager.score += this.score;
	}
}
