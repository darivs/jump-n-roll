using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 15;
	public float jumpForce = 1500;
	public Transform groundCheck;	
	public LayerMask whatIsGround;
	[HideInInspector]
	public Rigidbody2D rb2d;
	//private Animator anim;
	private bool isGrounded = false;
	private bool jump = false;
	public float velocity;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		//anim = GetComponent<Animator> ();

	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position += Vector3.right * speed * Time.deltaTime;
		if (Input.GetButtonDown("Jump") && isGrounded || Input.touches.Length == 1)
			jump = true;
	}

	void FixedUpdate() {
		float hor = Input.GetAxis("Horizontal");
		velocity = speed + 10;
		//anim.SetFloat("Speed", Mathf.Abs(hor));
	
		rb2d.velocity = new Vector2 (hor * speed+10, rb2d.velocity.y);

		Invoke ("GetFast", 1);

		isGrounded = Physics2D.OverlapCircle (groundCheck.position, 1.25F, whatIsGround);

		//anim.SetBool("IsGrounded", isGrounded);

		if (jump) {
			rb2d.AddForce(new Vector2(0,jumpForce));
			jump = false;
		}
	}

	void GetFast()
	{
		velocity++;
	}
}
