using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {


    [HideInInspector]
    public GameObject bullet;
    public BulletManager._ColorBullet currentColor;
    public Sprite[] pointValues;
	public bool toxic = true;
    public SpriteRenderer pointValue;
    
    

	// Use this for initialization
	void Start () {
        bullet = this.gameObject;
        pointValue = GetComponentInChildren<SpriteRenderer>();
        pointValue.GetComponent<Renderer>().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
        

		//code that changes the color of the bullet, nothing else.
		if (currentColor == BulletManager._ColorBullet.Pink)
			this.GetComponent<Renderer>().material.color = Color.blue + Color.red + Color.yellow;
		else if(currentColor == BulletManager._ColorBullet.Red)
			this.GetComponent<Renderer>().material.color = Color.red;
		else if(currentColor == BulletManager._ColorBullet.Orange)
			this.GetComponent<Renderer>().material.color = new Color32(255, 145, 0, 255);
		else if(currentColor == BulletManager._ColorBullet.Yellow)
			this.GetComponent<Renderer>().material.color = Color.red + Color.yellow + Color.grey;
		else if(currentColor == BulletManager._ColorBullet.Green)
			this.GetComponent<Renderer>().material.color = Color.green;
		else if(currentColor == BulletManager._ColorBullet.Blue)
			this.GetComponent<Renderer>().material.color = Color.blue;
		else if(currentColor == BulletManager._ColorBullet.Purple)
			this.GetComponent<Renderer>().material.color = Color.magenta;
		else if(currentColor == BulletManager._ColorBullet.Brown)
			this.GetComponent<Renderer>().material.color = new Color32(99, 59, 5, 255);
		else if(currentColor == BulletManager._ColorBullet.Black)
			this.GetComponent<Renderer>().material.color = Color.black;
	}

    public void MoveSprite(GameObject Sother) {
        this.gameObject.transform.position = Sother.transform.position;
    }

    //public IEnumerator GUIFunction(float time) {
    //    pointValue.renderer.enabled = true;
    //    yield return new WaitForSeconds(time);
    //    pointValue.renderer.enabled = false;
    //}


}
