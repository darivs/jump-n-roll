using UnityEngine;
using System.Collections;

public class SpikeDamage : MonoBehaviour {
	
	public float damage = 1;
	
	HealthController hc;
	
	void Start()
	{
		hc = GameObject.Find ("Player").GetComponent<HealthController> ();
	}
	
	void OnTriggerEnter2D(Collider2D spike)
	{
		
		if (spike.CompareTag ("Player")) 
		{
			hc.applyDamage (damage);
		}
	}
	
	/*void OnTriggerStay2D(Collider2D spike)
	{
		
		if (spike.CompareTag ("Player")) 
		{
			hc.applyDamage (damage);
		}
	}*/
}
