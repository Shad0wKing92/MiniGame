using UnityEngine;
using System.Collections;

public class CurColor : MonoBehaviour {

	BulletManager BM;

	// Use this for initialization
	void Start () {
		BM = GameObject.FindGameObjectWithTag ("BulletManager").GetComponent<BulletManager> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (BM.number == 0)
			this.GetComponent<Renderer>().material.color = Color.blue + Color.red + Color.yellow;
		else if(BM.number == 1)
			this.GetComponent<Renderer>().material.color = Color.red;
		else if(BM.number == 2)
			this.GetComponent<Renderer>().material.color = new Color32(255, 145, 0, 255);
		else if(BM.number == 3)
			this.GetComponent<Renderer>().material.color = Color.red + Color.yellow + Color.grey;
		else if(BM.number == 4)
			this.GetComponent<Renderer>().material.color = Color.green;
		else if(BM.number == 5)
			this.GetComponent<Renderer>().material.color = Color.blue;
		else if(BM.number == 6)
			this.GetComponent<Renderer>().material.color = Color.magenta;
		else if(BM.number == 7)
			this.GetComponent<Renderer>().material.color = new Color32(99, 59, 5, 255);
		else if(BM.number == 8)
			this.GetComponent<Renderer>().material.color = Color.grey;

	}
}
