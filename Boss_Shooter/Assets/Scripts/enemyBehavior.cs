using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehavior : MonoBehaviour {
	[Header("Enemy Health")]
	public int startingHealth = 100; //the max health of enemy gameObject
	public int currentHealth; //current health of the enemy gameObject

	// Use this for initialization
	void Start () {
		//initalize the current health to starting health
		currentHealth = startingHealth; 
	}
	
	// Update is called once per frame
	void Update () {
		//if current health is 0, this object should die
		if (currentHealth <= 0)
		{
			Die();
       
		}

        Debug.Log(currentHealth);
	}

	void Die()
	{
		//kill this object
		Destroy(gameObject);
	}
}

// Testing git 10.22.18