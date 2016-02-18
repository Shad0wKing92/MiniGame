using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ResetClick(){
		Application.LoadLevel (1);
	}

	public void StartClick(Timer timer){
			timer.StartTime();
	}
}
