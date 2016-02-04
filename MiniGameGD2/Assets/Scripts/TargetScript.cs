using UnityEngine;
using System.Collections;

public class TargetScript : MonoBehaviour {

    //enum EpointValues { n10, n20, n30, n40, n50, p10, p20, p30, p40, p50 };
    //EpointValues CurValue;
	public int TargetPointValue;
	PointManager PM;
	Bullet BS;

	void Start () {
		PM = GameObject.FindGameObjectWithTag ("PointManager").GetComponent<PointManager> ();
		BS = GameObject.FindGameObjectWithTag ("Bullet").GetComponent<Bullet> ();
	}

	void OnCollisionEnter(Collision other){
        if (other.gameObject.tag == "Bullet") {
            CheckPointValue();
            BS.MoveSprite(other.gameObject);
			other.transform.GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 0);
			other.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
		}
        if (!BS.toxic){
            PM.AddToScore(TargetPointValue);
        }
        else{
            PM.SubFromScore(TargetPointValue);
        }

	}

    void CheckPointValue()
    {
        //BS.StartCoroutine(BS.GUIFunction(20f));
        if (BS.toxic)
        {
            if (TargetPointValue == 10)
                BS.pointValue.sprite = BS.pointValues[0];
            if (TargetPointValue == 20)
                BS.pointValue.sprite = BS.pointValues[1];
            if (TargetPointValue == 30)
                BS.pointValue.sprite = BS.pointValues[2];
            if (TargetPointValue == 40)
                BS.pointValue.sprite = BS.pointValues[3];
            if (TargetPointValue == 50)
                BS.pointValue.sprite = BS.pointValues[4];
        }
        else if (!BS.toxic)
        {
            if (TargetPointValue == 10)
                BS.pointValue.sprite = BS.pointValues[5];
            if (TargetPointValue == 20)
                BS.pointValue.sprite = BS.pointValues[6];
            if (TargetPointValue == 30)
                BS.pointValue.sprite = BS.pointValues[7];
            if (TargetPointValue == 40)
                BS.pointValue.sprite = BS.pointValues[8];
            if (TargetPointValue == 50)
                BS.pointValue.sprite = BS.pointValues[9];
        }

    }


}
