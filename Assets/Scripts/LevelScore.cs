using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelScore : MonoBehaviour {
	
	int score;
	public string level;
	
	Text text;
	
	// Use this for initialization
	void Start () 
	{
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		score = PlayerPrefs.GetInt("LvlPunkte");

		if (level == "Level1") 
		{
			if (score > 3)
				score = 3;
		}
		else
		{
			if (level == "Level2") 
			{
				if (score > 6)
					score = 6;
			}
			else if (level == "Level3") 
			{
				if (score > 9)
					score = 9;
			}
		}

		text.text = "" + score;
		
	}
}
