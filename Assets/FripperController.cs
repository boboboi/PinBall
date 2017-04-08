using UnityEngine;
using System.Collections;

public class FripperController : MonoBehaviour {
	//HingiJointコンポーネントを入れる
	private HingeJoint myHingeJoint;

	//初期の傾き
	private float defaultAngle = 20;
	//弾いた時の傾き
	private float flickAngle = -20;

	private int xsize = 354;

	// Use this for initialization
	void Start () {
		//HinjiJointコンポーネント取得
		this.myHingeJoint = GetComponent<HingeJoint>();

		//フリッパーの傾きを設定
		SetAngle(this.defaultAngle);
	}

	// Update is called once per frame
	void Update () {

		//画面左をクリック時左フリッパーを動かす
		if (Input.GetMouseButtonDown (0) && tag == "LeftFripperTag") {
			if (Input.mousePosition.x < (xsize/2) ) {
				SetAngle (this.flickAngle);
			}
		}

		//画面右をクリック時右フリッパーを動かす
		if (Input.GetMouseButtonDown (0) && tag == "RightFripperTag") {
			if (Input.mousePosition.x >= (xsize/2) ) {
				SetAngle (this.flickAngle);
			}
		}

		//矢印キー離された時フリッパーを元に戻す
		if (Input.GetMouseButtonUp (0)) {
			SetAngle (this.defaultAngle);
		}

		//左矢印キーを押した時左フリッパーを動かす
		if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag") {
			SetAngle (this.flickAngle);
		}
		//右矢印キーを押した時右フリッパーを動かす
		if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag") {
			SetAngle (this.flickAngle);
		}

		//矢印キー離された時フリッパーを元に戻す
		if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)) {
			SetAngle (this.defaultAngle);
		}
	}

	//フリッパーの傾きを設定
	public void SetAngle (float angle){
		JointSpring jointSpr = this.myHingeJoint.spring;
		jointSpr.targetPosition = angle;
		this.myHingeJoint.spring = jointSpr;
	}
}