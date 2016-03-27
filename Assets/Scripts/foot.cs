using UnityEngine;
using System.Collections;

public class foot : MonoBehaviour {
	public float kickPower;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Ball" && GetComponentInParent<playerMovement>().kickbool) {
			coll.rigidbody.AddForce (Vector2.up * kickPower, ForceMode2D.Impulse);
		}
	}


}
