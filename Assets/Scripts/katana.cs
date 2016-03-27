using UnityEngine;
using System.Collections;

public class katana : MonoBehaviour {
	public float katanaPower;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Ball" && playerMovement.S.katanabool) {
			coll.rigidbody.AddForce (Vector2.right * katanaPower, ForceMode2D.Impulse);
		}
	}


}
