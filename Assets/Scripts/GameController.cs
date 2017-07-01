using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
		while (true) {
			yield return new WaitForSecondsRealtime (1f);
			NotificationCenter.Instance.Notify ("CountDown");
		}
	}


	
	// Update is called once per frame
	void Update () {
		
	}
}
