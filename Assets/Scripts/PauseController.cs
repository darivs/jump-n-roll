using UnityEngine;
using System.Collections;

public class PauseController : MonoBehaviour {

	private bool pauseGame = false;
	private bool showGUI = false;
	PlayerController pc;
	GameObject tina;
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown("Pause")) 
		{
			pauseGame = !pauseGame;
			
			if (pauseGame == true) {
				Time.timeScale = 0;
				pauseGame = true;
				pc = GameObject.Find ("Player").GetComponent<PlayerController> ();
				pc.speed = 0;
				showGUI = true;
			}			
		}
	}

	void FixedUpdate ()
	{
		if (pauseGame == true) 
		{
			Time.timeScale = 1;
			pauseGame = false;
			pc = GameObject.Find("Player").GetComponent<PlayerController> ();
			pc.speed = 1;
			showGUI = false;
		}
		
		if (showGUI == true) {

			tina = GameObject.Find ("Image");
			tina.transform.Rotate(2,0,0);
		} else {
			tina = GameObject.Find ("Image");
			tina.transform.Rotate(1,0,0);
		}
	}


}