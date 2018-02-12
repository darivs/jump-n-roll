using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour {

	public float startHealth = 1;
	private float health = 1;

	private Animator anim;
	private PlayerController playerController;
	private Rigidbody2D rb2d;
	private bool isDead = false;
	public GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		anim = GetComponent<Animator> ();
		playerController = GetComponent<PlayerController> ();
		rb2d = GetComponent<Rigidbody2D> ();

		//Level Index anpassen falls Menue! 0 = ERSTE Szene
		if (Application.loadedLevel == 0) 
		{
			health = startHealth;
		} 
		else 
		{
			health = PlayerPrefs.GetFloat ("Health");
		}
	}

	public void applyDamage(float damage)
	{
		health -= damage;
		health = Mathf.Max (0,health);
		
		if (!isDead) 
		{
			if (health == 0) 
			{
				isDead = true;
				dying ();
			} 
		}
	}

	void restartScene()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

	void dying()
	{
		anim.SetTrigger ("Dmg");
		anim.SetBool ("Dead", true);
		playerController.enabled = false;
		rb2d.velocity = new Vector2 (0,0);
		Invoke ("Died", 1);
	}

	void Died()
	{
		health = startHealth;
		isDead = false;
		anim.SetBool ("Dead", false);
		Application.LoadLevel ("Died");

		/*
		anim.SetBool ("Dead", false);
		playerController.enabled = true;
		*/
	}
	

	void OnDestroy()
	{
		PlayerPrefs.SetFloat("Health",health);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
