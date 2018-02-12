using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FinishedScore : MonoBehaviour {

	int score;

	Text text;

	// Use this for initialization
	void Start () 
	{
		text = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () 
	{
		score = PlayerPrefs.GetInt ("Punkte");
		
		text.text = "" + score;
	
	}
}
