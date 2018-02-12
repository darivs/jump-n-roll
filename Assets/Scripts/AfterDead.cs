using UnityEngine;
using System.Collections;

public class AfterDead : MonoBehaviour {

	public string currentLevel;

	// Use this for initialization
	public void RestartLevel () 
	{
		Application.LoadLevel (currentLevel);
	}

	public void GoToMainMenu()
	{
		Application.LoadLevel ("Main Menu");
	}

	public void GoToLevelMenu()
	{
		Application.LoadLevel ("Level Menu");
	}

	void Update()
	{
		if(Input.GetButtonDown("Jump"))
		{
			Application.LoadLevel (currentLevel);
		}
	}

}
