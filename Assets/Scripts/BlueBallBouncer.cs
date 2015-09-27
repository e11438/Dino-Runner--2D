using UnityEngine;
using System.Collections;

public class BlueBallBouncer : MonoBehaviour {
	public float offset;
	public static  float maxHeight;
	//private bool bouncedForFirstTime;
	
	private int numOfBounces;
	
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;
	
	// Use this for initialization
	void Start () {
		
		System.Random rng=new System.Random();;
		numOfBounces = 0;
		grounded = false;
		maxHeight = (float)(offset+rng.NextDouble () * 9f);
		
		
	}
	void FixedUpdate(){
		if (Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround)) {
			numOfBounces++;
			grounded = true;
		}	
		
	}
	
	
	// Update is called once per frame
	void Update () {
		if(grounded){
			
			Jump(maxHeight/numOfBounces);
			grounded=false;
			
		}
		
	}
	
	public void Jump(float jumpHeight){
		rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x,jumpHeight);
	}
}
