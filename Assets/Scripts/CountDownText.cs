using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownText : MonoBehaviour {

	int count = 20;

	Text text;

	// Use this for initialization
	void Start () {

		text = GetComponent<Text> ();

		NotificationCenter.Instance.Add ("CountDown", OnCountDown);
	}

	void OnCountDown(){
		count --;
		text.text = count.ToString();		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
