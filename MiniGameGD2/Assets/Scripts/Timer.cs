using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public int timer = 1000;
	public bool timerRunning = false;
	public Text timeLabel;

	// Use this for initialization
	void Start () {
//		timeLabel = GetComponent<Text>();
//		print (timeLabel.text);
	}
	
	// Update is called once per frame
	void Update () {
		timeLabel.text = "Time: " + timer.ToString(); 

		checkTimer ();
	}

	void checkTimer(){
		if (timerRunning)
			timer--;
		
		if (timer == 0) {
			timerRunning = false;

		}
	}

	public void StartTime()
	{
		timerRunning = true;
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
