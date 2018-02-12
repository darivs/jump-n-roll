using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {

	int score;
	int staticScore;

	// Update is called once per frame
	void Update()
	{
		score = PlayerPrefs.GetInt ("Punkte");

		if (score > 3) 
		{
			score = 3;
		}
		else 
		{
			if (score == 3) 
			{
				staticScore = 3;
			}
		}

		PlayerPrefs.SetInt ("LvlPunkte", staticScore);
	}

	// Use this for initialization
	void OnTriggerEnter2D()
	{
		Finished ();
	}

	void Finished()
	{
		if (score == 3) 
		{
			Application.LoadLevel ("Finished");	
		}
		else 
		{
			Application.LoadLevel ("Died");			
		}
	}
	
}
