using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float moveSpeed;
	public float jumpHeight;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;

	private bool doubleJumped;

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	
	}

	void FixedUpdate(){
		grounded = Physics2D.OverlapCircle (groundCheck.position,groundCheckRadius,whatIsGround);

		

	}
	
	// Update is called once per frame
	void Update () {
		if (grounded) {
			doubleJumped=false;

		}
		anim.SetBool("Grounded",grounded);

#if UNITY_STANDALONE||UNITY_WEBPLAYER

		if((Input.GetKeyDown(KeyCode.Space))&&grounded){

			Jump();
		
		}
		//||Input.GetMouseButtonDown(0)
		if((Input.GetKeyDown(KeyCode.Space))&&!doubleJumped&&!grounded){
			
			Jump();
			doubleJumped=true;
			
		}
#endif
		rigidbody2D.velocity = new Vector2(moveSpeed,rigidbody2D.velocity.y);

		anim.SetFloat ("Speed",rigidbody2D.velocity.x);
	}

	public void Jump(){
		//rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x,jumpHeight);
	
		if(grounded){
			
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x,jumpHeight);
			
		}
		//||Input.GetMouseButtonDown(0)
		if (!doubleJumped && !grounded) {
			
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, jumpHeight);
			doubleJumped = true;
		}
	}
}
