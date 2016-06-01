using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public int timer = 1000;
	public bool timerRunning = false;
	public Text timeLabel;
	public GameObject TImesUP, CountDown, back;
	float time = 1f;
	float ElapsedTime = 0.0f;
	Color CountAlpha;
	Text CountText;

	// Use this for initialization
	void Start () {
//		timeLabel = GetComponent<Text>();
//		print (timeLabel.text);
		TImesUP.SetActive (false);
		CountDown.SetActive(false);
//		CountAlpha = CountDown.GetComponent<Renderer>().material.color;
		CountText = CountDown.GetComponent<Text>();
		CountAlpha = CountText.color;
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
		StartCoroutine(wait());
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

	IEnumerator wait(){

//		yield return new WaitForSeconds(0.1f);
		CountDown.SetActive(true);
		while(ElapsedTime <= time){
			ElapsedTime += Time.deltaTime;
			CountAlpha = Color.Lerp(new Color(1,1,1,1), new Color(1,1,1,0), (ElapsedTime / time));
			CountText.color = CountAlpha;
			yield return null;
		}
		CountText.text = "2";
		CountAlpha = new Color(1,1,1,1);
		ElapsedTime = 0f;
		while(ElapsedTime <= time){
			ElapsedTime += Time.deltaTime;
			CountAlpha = Color.Lerp(new Color(1,1,1,1), new Color(1,1,1,0), (ElapsedTime / time));
			CountText.color = CountAlpha;
			yield return null;
		}
		CountText.text = "1";
		CountAlpha = new Color(1,1,1,1);
		ElapsedTime = 0f;
		while(ElapsedTime <= time){
			ElapsedTime += Time.deltaTime;
			CountAlpha = Color.Lerp(new Color(1,1,1,1), new Color(1,1,1,0), (ElapsedTime / time));
			CountText.color = CountAlpha;
			yield return null;
		}
		CountText.text = "Fire!";
		CountAlpha = new Color(1,1,1,1);
		ElapsedTime = 0f;
		while(ElapsedTime <= time){
			ElapsedTime += Time.deltaTime;
			CountAlpha = Color.Lerp(new Color(1,1,1,1), new Color(1,1,1,0), (ElapsedTime / time));
			CountText.color = CountAlpha;
			yield return null;
		}
		timerRunning = true;
		CountDown.SetActive(false);
		back.SetActive(false);
		StartCoroutine (Clock ());
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
