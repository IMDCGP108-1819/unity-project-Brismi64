using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour {

	// set speed and damage values as well as the 2D rigidbody
	public float Speed;
	public Rigidbody2D RB;
	public int Damage = 50;

	// move right the set speed on script start
	void Start () 
	{
		RB.velocity = transform.right * Speed;
	}
	
	// on enemy hit, enemy takes damage and beam is destroyed
	void OnTriggerEnter2D(Collider2D Hit)
	{
	
		Enemy enemy = Hit.GetComponent<Enemy>();
		if (enemy != null)
		{
			enemy.HitDamage(Damage);
		}
		Destroy(gameObject);

	}

}
