using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	public void startGame () 
	{
		Application.LoadLevel ("Level Menu");	
	}
	
	// Update is called once per frame
	public void quitGame () 
	{
		Application.Quit ();	
	}

	public void options ()
	{
		Application.LoadLevel ("Options");
	}
}
