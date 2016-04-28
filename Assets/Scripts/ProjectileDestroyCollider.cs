﻿using UnityEngine;
using System.Collections;

public class ProjectileDestroyCollider : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D trigger){
		Destroy (trigger.gameObject);
	}

}
