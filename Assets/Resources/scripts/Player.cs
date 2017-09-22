using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private bool isGrounded;
	private float volume = 1.0f;
	private Rigidbody2D rb;
	private float jumpForce = 2.0f;
	private Vector2 jumpingChar = new Vector2(0, 3.0f);
	
	public AudioClip jumpSound;
	
	void Start(){
		//startingPlayerPos = this.transform.position;
		isGrounded = true;
		rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
		if(Input.GetKeyDown("space") && isGrounded){
			Jump();
		}
	}
	
	void OnCollisionStay2D(Collision2D coll){
		isGrounded = true;
	}
	
	void Jump(){
		rb.AddForce(jumpingChar * jumpForce, ForceMode2D.Impulse);
		AudioSource.PlayClipAtPoint(jumpSound, transform.position, volume);
		isGrounded = false;
	}
}
