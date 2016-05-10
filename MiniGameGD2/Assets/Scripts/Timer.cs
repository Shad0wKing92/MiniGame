using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public int timer = 1000;
	public bool timerRunning = false;
	public Text timeLabel;
	public GameObject TImesUP;

	// Use this for initialization
	void Start () {
//		timeLabel = GetComponent<Text>();
//		print (timeLabel.text);
		TImesUP.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		timeLabel.text = "Time: " + timer.ToString(); 

		if (timer == 0) {
			TImesUP.SetActive (true);
		} else {
			TImesUP.SetActive (false);
		}
		//checkTimer ();
	}

//	void checkTimer(){
//		//if (timerRunning)
//		//	timer--;
//
//
//
//		if (timer == 0) {
//			timerRunning = false;
//
//		}
//	}

	public void StartTime()
	{
		timerRunning = true;
		StartCoroutine (Clock ());
	}

	IEnumerator Clock()
	{
		yield return new WaitForSeconds(1);
		if (timer > 0) {
			timer --;
			StartCoroutine (Clock ());
		}
		if (timer == 0) {
			timerRunning = false;
		}
	}

//	public void StartClick(){
//		StartTime();
//	}
//	public void OnClick()
//	{
//		GUI.Label (new Rect (10, 40, 100, 100), ("time: " + timer));
//
//		if(!timerRunning){
//			if(){
//				Application.LoadLevel(0);
//			}
//		}
//		if(timer == 1000){
//			if (GUI.Button (new Rect (10, 125, 100, 50), ("Start"))) {
//				StartTime ();	
//			}
//		}
//	}
}
