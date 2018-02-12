using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	private Vector2 velocity;
	public float smoothTimeY;
	public float smoothTimeX;
	private float posX;
	private float posY;

	public GameObject player;
	private Animator anim;

	private bool dead = false;

	// Use this for initialization
	void Start () 
	{
		player = GameObject.Find ("Player");
		anim = player.GetComponent<Animator> ();
		posX = player.transform.position.x;
		posY = player.transform.position.y;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		dead = anim.GetBool ("Dead");

		if (!dead) 
		{
			if (player.transform.position.y > 6) 
			{
				posY = Mathf.SmoothDamp (transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY) - Mathf.SmoothDamp (1, 1, ref velocity.y, smoothTimeY);
				posX = Mathf.SmoothDamp (transform.position.x + 8, player.transform.position.x + 8, ref velocity.x, smoothTimeX);
			} 
			else
			{
				if (player.transform.position.y < -2) 
				{
					posY = Mathf.SmoothDamp (transform.position.y+6, player.transform.position.y+6, ref velocity.y, smoothTimeY) + Mathf.SmoothDamp (1, 1, ref velocity.y, smoothTimeY);
					posX = Mathf.SmoothDamp (transform.position.x + 8, player.transform.position.x + 8, ref velocity.x, smoothTimeX);
				}
				else
				{
					posY = Mathf.SmoothDamp (5, 5, ref velocity.y, smoothTimeY);
					posX = Mathf.SmoothDamp (transform.position.x + 8, player.transform.position.x + 8, ref velocity.x, smoothTimeX);
				}
			} 
		}

		transform.position = new Vector3 (posX, posY, transform.position.z);
	
	}
}
