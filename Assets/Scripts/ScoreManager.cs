using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	[HideInInspector]
	public static int tempScore = 0;
	public static int score;

	Text text;

	// Use this for initialization
	void Start () 
	{
		text = GetComponent<Text> ();

		tempScore = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if (tempScore < 0) {
			tempScore = 0;
		}
		text.text = "" + tempScore;

		PlayerPrefs.SetInt ("Punkte", tempScore);
	
	}

	public static void AddPoints(int pointToAdd)
	{
		tempScore += pointToAdd;
	}

	public static void Reset()
	{
		tempScore = 0;
	}

}
