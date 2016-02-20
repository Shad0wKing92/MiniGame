using UnityEngine;
using System.Collections;

public class PointManager : MonoBehaviour {

	public int score;
    
	void Start () {
    
	}
	
	void Update () {
	
	}

	public void AddToScore(int amount){
		score += amount;
        //soundManager.AudioSource.Play(); Good Ping
	}

	public void SubFromScore(int amount){
		score -= amount;
        //soundManager.AudioSource.Play(); Bad Ping
	}

//	void OnGUI(){
//		GUI.Label (new Rect (10, 10, 150, 150), "Score: " + score);
//        
//	}
}
