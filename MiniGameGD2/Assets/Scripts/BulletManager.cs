using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BulletManager : MonoBehaviour {

	public Text BulletText;

	public enum _ColorBullet{Pink, Red, Orange, Yellow, Green, Blue, Purple, Brown, Black};
//	public _ColorBullet currentColor;
	[HideInInspector]public int number;
	int totalBulletsFired;

	// Use this for initialization
	void Start () {
		number = Random.Range(0,9);
	}

	void Update () {
		BulletText.text = "Bullets Fired: " + totalBulletsFired;
	}

//	void OnGUI(){
//		GUI.Label (new Rect (10, 25, 150, 150), "Bullets Fired: " + totalBulletsFired);
//	}

	public void NewRand(){
		number = Random.Range(0,9);
	}

	public void AddToTotalBulFir(){
		totalBulletsFired++;
	}
}
