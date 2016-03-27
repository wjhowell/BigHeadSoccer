using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
	public static playerMovement S;

    public int playerNumber;

	Rigidbody2D rigid;
	Animator anim;
	BoxCollider2D foot;

	public float speed = 0f;
	public float jump = 0f;
	public float moveX = 0f;
	public float moveY = 0f;
	public float kick = 0f;
	public bool kickbool;
    public float katana = 0f;
    public bool katanabool;


	void Start () {
		S = this;
		rigid = GetComponent<Rigidbody2D> ();
		anim = GetComponentInChildren<Animator> ();
	}
	
	void FixedUpdate () {
		moveX = Input.GetAxis ("Horizontal" + playerNumber);
		moveY = Input.GetAxis ("Vertical" + playerNumber);
		kick = Input.GetAxis ("Jump" + playerNumber);//spacebar
        //katana = Input.GetAxis("Jump");//spacebar
        rigid.velocity = new Vector2 (moveX * speed, rigid.velocity.y);
        kickbool = System.Convert.ToBoolean (kick);
        //katanabool = System.Convert.ToBoolean(katana);
        anim.SetBool ("kick", kickbool);
        //anim.SetBool("katana", katanabool);
    }

	void OnCollisionStay2D(Collision2D coll )
	{
		if (coll.gameObject.tag == "Ground" && (moveY > 0)) {//if grounded
			rigid.AddForce (Vector2.up * jump, ForceMode2D.Impulse);
		}
	}
}
