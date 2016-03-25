using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
	public static playerMovement S;

	Rigidbody2D rigid;
	Animator anim;
	BoxCollider2D foot;

	public float speed = 0f;
	public float jump = 0f;
	public float moveX = 0f;
	public float moveY = 0f;
	public float kick = 0f;
	public bool kickbool;

	public int goalsScored;

	void Start () {
		S = this;
		rigid = GetComponent<Rigidbody2D> ();
		anim = GetComponentInChildren<Animator> ();
		foot = GetComponentInChildren<BoxCollider2D> ();

		goalsScored = 0;
	}
	
	void FixedUpdate () {
		moveX = Input.GetAxis ("Horizontal");
		moveY = Input.GetAxis ("Vertical");
		kick = Input.GetAxis ("Jump");//spacebar
		rigid.velocity = new Vector2 (moveX * speed, rigid.velocity.y);
		kickbool = System.Convert.ToBoolean (kick);
		anim.SetBool ("kick", kickbool);
	}

	void OnCollisionStay2D(Collision2D coll )
	{
		if (coll.gameObject.tag == "Ground" && (Input.GetKey (KeyCode.W))) {//if grounded
			rigid.AddForce (Vector2.up * jump, ForceMode2D.Impulse);
		}
	}
}
