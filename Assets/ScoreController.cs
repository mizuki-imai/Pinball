using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
	
public class ScoreController : MonoBehaviour{
	
	//得点を表示するテキストを設定
	public GameObject ScoreText;

	//得点のデフォルトの数値
	private int point = 0;

	// Use this for initialization
	void Start () {
		point = 0;
	//シーン中のScoreTextオブジェクトを取得
		this.ScoreText = GameObject.Find("ScoreText");
		SetScore ();

	}
	
	// Update is called once per frame
	void Update (){}

		//ボールがオブジェクトに当たった場合
		void OnCollisionEnter(Collision other){
		//対象のオブジェクトを取得
		string yourTag = other.gameObject.tag;

		//タグによって加える数字を変える
		if (yourTag == "SmallStarTag") {
			point += 10;
		} else if (yourTag == "LargeStarTag") {
			point += 20;
		} else if (yourTag == "SmallCloudTag") {
			point += 30;
		} else if (yourTag == "LargeCloudTag") {
			point += 60;
		}
		SetScore ();

	}

	void SetScore (){
		Text textComponent = ScoreText.GetComponent<Text> ();
		textComponent.text = string.Format ("Score:{0}", point);
	}
}
			

