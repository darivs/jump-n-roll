using UnityEngine;
using System.Collections;

public class CoinUpPicker : MonoBehaviour {

	public int pointToAdd;
	// Use this for initialization
	void Start()
	{
		pointToAdd = 1;
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) 
	{
		if (other.GetComponent<PlayerController> () == null) {
			return;
		}

		ScoreManager.AddPoints (pointToAdd);
		Destroy (gameObject);
	}
}
