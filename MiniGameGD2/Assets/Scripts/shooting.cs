using UnityEngine; 
using System.Collections;

public class shooting : MonoBehaviour 
{
	public float bulletSpeed;
	public float distance;
	public Rigidbody[] bullet;
	BulletManager BM;
	public Vector2 startPos;
	public Vector2 direction;
	public bool directionChosen;
	Timer TS;


	

	void Start(){
		BM = GameObject.FindGameObjectWithTag ("BulletManager").GetComponent<BulletManager> ();
		TS = GameObject.FindGameObjectWithTag ("Timer").GetComponent<Timer> ();
	}

	void Fire()
	{
		Vector3 position = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		position = Camera.main.ScreenToWorldPoint (position);
		Rigidbody bulletClone = Instantiate(bullet[BM.number], transform.position, Quaternion.identity) as Rigidbody;
		bulletClone.transform.LookAt (position);
//		print (position);
        //soundManager.AudioSource.Play();
		bulletClone.GetComponent<Rigidbody>().AddForce (bulletClone.transform.forward * bulletSpeed);
		BM.AddToTotalBulFir ();
		BM.NewRand();
	}
	
	void Update () 
	{
		if (Input.touchCount > 0) {
			Touch touch = Input.GetTouch(0);
			if(TS.timerRunning){
				switch(touch.phase){
				case TouchPhase.Began:
					startPos = touch.position;
					directionChosen = false;
					break;
				case TouchPhase.Moved:
					direction = touch.position - startPos;
					break;
				case TouchPhase.Ended:
					directionChosen = true;
					Fire();
					break;
				}
			}
		}

//		if (TS.timerRunning) {
//			if (Input.GetMouseButtonDown (0))
//				Fire ();
//		}
	}
}