using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public int timer = 1000;
	public bool timerRunning = false;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (timerRunning)
			timer--;

		if (timer == 0)
			timerRunning = false;
	}


	void StartTime()
	{
		timerRunning = true;
	}

	void OnGUI()
	{
		GUI.Label (new Rect (10, 40, 100, 100), ("time: " + timer));

		if(!timerRunning){
			if(GUI.Button (new Rect(10, 75, 100, 50), ("Reset"))){
				Application.LoadLevel(0);
			}
		}
		if(timer == 1000){
			if (GUI.Button (new Rect (10, 125, 100, 50), ("Start"))) {
				StartTime ();	
			}
		}
	}
}
