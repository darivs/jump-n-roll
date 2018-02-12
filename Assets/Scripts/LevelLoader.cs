using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {

	public string level1;
	public string level2;
	public string level3;
	
	public void LoadLevel1 ()
	{
		Application.LoadLevel (level1);
	}

	public void LoadLevel2 ()
	{
		Application.LoadLevel (level2);
	}

	public void LoadLevel3 ()
	{
		Application.LoadLevel (level3);
	}

	public void LoadMainMenu ()
	{
		Application.LoadLevel ("Main Menu");
	}
}
