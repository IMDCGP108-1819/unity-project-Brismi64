using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

	// set variable type for Attack_Point and Beam
	public Transform Attack_Point;
	public GameObject Beam;

    public Animator animator;

    // on left click, shoot
    void Update () 
	{
		if (Input.GetButtonDown("Fire1"))
		{
			Shoot();

            animator.SetBool("Is_Attacking", true);
		}

        if (Input.GetButtonUp("Fire1"))
        {
            animator.SetBool("Is_Attacking", false);
        }
	}

	// create Beam at Attack_Point
	void Shoot ()
	{
		Instantiate(Beam, Attack_Point.position, Attack_Point.rotation);
	}
}
