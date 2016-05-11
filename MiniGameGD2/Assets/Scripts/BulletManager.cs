using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BulletManager : MonoBehaviour {

	public Text BulletText;

	public enum _ColorBullet{Pink, Red, Orange, Yellow, Green, Blue, Purple, Brown, Black};
//	public _ColorBullet currentColor;
	[HideInInspector]public int number;
	int totalBulletsFired;
	ColorScript CS;

	// Use this for initialization
	void Start () {
		NewRand ();
	}

	void Update () {
		BulletText.text = "Bullets Fired: " + totalBulletsFired;
	}

//	void OnGUI(){
//		GUI.Label (new Rect (10, 25, 150, 150), "Bullets Fired: " + totalBulletsFired);
//	}

	public void NewRand(){
		number = Random.Range(0,9);
		switch (number) {
		case 0:	
			CS = GameObject.Find ("Pink").GetComponent<ColorScript> ();
			break;
		case 1:	
			CS = GameObject.Find ("Red").GetComponent<ColorScript> ();
			break;
		case 2:	
			CS = GameObject.Find ("Orange").GetComponent<ColorScript> ();
			break;
		case 3:	
			CS = GameObject.Find ("Yellow").GetComponent<ColorScript> ();
			break;
		case 4:	
			CS = GameObject.Find ("Green").GetComponent<ColorScript> ();
			break;
		case 5:	
			CS = GameObject.Find ("Blue").GetComponent<ColorScript> ();
			break;
		case 6:	
			CS = GameObject.Find ("Purple").GetComponent<ColorScript> ();
			break;
		case 7:	
			CS = GameObject.Find ("Brown").GetComponent<ColorScript> ();
			break;
		case 8:	
			CS = GameObject.Find ("Black").GetComponent<ColorScript> ();
			break;
		}
		CS.ColSwitch ();
	}

	public void AddToTotalBulFir(){
		totalBulletsFired++;
	}
}
