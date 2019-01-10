using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	//set health
	public int Health = 100;

	//add damage function (health - damage, if health goes below zero, destroy)
	public void HitDamage (int Damage)
	{
		Health -= Damage;

		if (Health <= 0)
		{
			Die();
		}

	}

	void Die ()
	{
		Destroy(gameObject);
	}

}
