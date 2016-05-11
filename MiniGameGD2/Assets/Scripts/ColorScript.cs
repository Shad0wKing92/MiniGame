using UnityEngine;
using System.Collections;

public class ColorScript : MonoBehaviour {

	public enum _Color{Pink, Red, Orange, Yellow, Green, Blue, Purple, Brown, Black};
	public _Color CurrentColor;
	public GameObject Border;
	Bullet BS;
	BulletManager BM;
	Color lerpedColor = Color.white;
	float time = 0.5f;
	int tempt;
	float ElapsedTime = 0.0f;

	// Use this for initialization
	void Start () {

		BS = GameObject.FindGameObjectWithTag ("Bullet").GetComponent<Bullet> ();
		BM = GameObject.FindGameObjectWithTag ("BulletManager").GetComponent<BulletManager> ();

		//Code that changes the color of the target itself
		if (CurrentColor == _Color.Pink)
			Border.GetComponent<Renderer>().material.color = Color.blue + Color.red + Color.yellow;
		else if(CurrentColor == _Color.Red)
			Border.GetComponent<Renderer>().material.color = Color.red;
		else if(CurrentColor == _Color.Orange)
			Border.GetComponent<Renderer>().material.color = new Color32(255, 145, 0, 255);
		else if(CurrentColor == _Color.Yellow)
			Border.GetComponent<Renderer>().material.color = Color.red + Color.yellow + Color.grey;
		else if(CurrentColor == _Color.Green)
			Border.GetComponent<Renderer>().material.color = Color.green;
		else if(CurrentColor == _Color.Blue)
			Border.GetComponent<Renderer>().material.color = Color.blue;
		else if(CurrentColor == _Color.Purple)
			Border.GetComponent<Renderer>().material.color = Color.magenta;
		else if(CurrentColor == _Color.Brown)
			Border.GetComponent<Renderer>().material.color = new Color32(99, 59, 5, 255);
		else if(CurrentColor == _Color.Black)
			Border.GetComponent<Renderer>().material.color = Color.grey;

	}
	
	// Update is called once per frame
	public void ColSwitch () {
		switch (BM.number) {
			case 0:
				if (CurrentColor == _Color.Pink) {
					StartCoroutine (Highlight (Color.blue + Color.red + Color.yellow));
				}
				break;
			case 1:
				if (CurrentColor == _Color.Red) {
					StartCoroutine (Highlight (Color.red));
				}
				break;
			case 2:
				if (CurrentColor == _Color.Orange) {
					StartCoroutine (Highlight (new Color32 (255, 145, 0, 255)));
				}
				break;
			case 3:
				if (CurrentColor == _Color.Yellow) {
					StartCoroutine (Highlight (Color.red + Color.yellow + Color.grey));
				}
				break;
			case 4:
				if (CurrentColor == _Color.Green) {
					StartCoroutine (Highlight (Color.green));
				}
				break;
			case 5:
				if (CurrentColor == _Color.Blue) {
					StartCoroutine (Highlight (Color.blue));
				}
				break;
			case 6:
				if (CurrentColor == _Color.Purple) {
					StartCoroutine (Highlight (Color.magenta));
				}
				break;
			case 7:
				if (CurrentColor == _Color.Brown) {
					StartCoroutine (Highlight (new Color32 (99, 59, 5, 255)));
				}
				break;
			case 8:
				if (CurrentColor == _Color.Black) {
					StartCoroutine (Highlight (Color.grey));
				}
				break;
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "PinkBullet(Clone)" && CurrentColor == _Color.Pink) 
			BS.toxic = false;
		else if (other.gameObject.name == "RedBullet(Clone)" && CurrentColor == _Color.Red)
			BS.toxic = false;
		else if (other.gameObject.name == "OrangeBullet(Clone)" && CurrentColor == _Color.Orange)
			BS.toxic = false;
		else if (other.gameObject.name == "YellowBullet(Clone)" && CurrentColor == _Color.Yellow)
			BS.toxic = false;
		else if (other.gameObject.name == "GreenBullet(Clone)" && CurrentColor == _Color.Green)
			BS.toxic = false;
		else if (other.gameObject.name == "BlueBullet(Clone)" && CurrentColor == _Color.Blue)
			BS.toxic = false;
		else if (other.gameObject.name == "PurpleBullet(Clone)" && CurrentColor == _Color.Purple)
			BS.toxic = false;
		else if (other.gameObject.name == "BrownBullet(Clone)" && CurrentColor == _Color.Brown)
			BS.toxic = false;
		else if (other.gameObject.name == "BlackBullet(Clone)" && CurrentColor == _Color.Black)
			BS.toxic = false;
		else
			BS.toxic = true;
	}

	IEnumerator Highlight(Color curdColor){
		tempt = BM.number;
		while (ElapsedTime < time) {
			ElapsedTime += Time.deltaTime;
			lerpedColor = Color.Lerp (Color.white, curdColor, (ElapsedTime / time));
			Border.GetComponent<Renderer> ().material.color = lerpedColor;
			yield return null;
		}
//		yield return new WaitForSeconds (time);
		ElapsedTime = 0f;
		while (ElapsedTime < time) {
			ElapsedTime += Time.deltaTime;
			lerpedColor = Color.Lerp (curdColor, Color.white, (ElapsedTime / time));
			Border.GetComponent<Renderer> ().material.color = lerpedColor;
			yield return null;
		}
//		yield return new WaitForSeconds (time);
		ElapsedTime = 0f;
		if (tempt == BM.number) {
			StartCoroutine(Highlight(curdColor));
		}else{
			Border.GetComponent<Renderer> ().material.color = curdColor;
		}
	}
}
