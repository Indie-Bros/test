﻿using UnityEngine;
using System.Collections;

public class shootBullet : MonoBehaviour {

	public float range = 10f;
	public float damage = 5f;

	Ray shootRay;
	RaycastHit shootHit;
	int shootableMask;
	LineRenderer gunLine;


	// Use this for initialization
	void Awake () {
		shootableMask = LayerMask.GetMask ("Shootable");
		gunLine = GetComponent<LineRenderer>();

		shootRay.origin = transform.position;
		shootRay.direction = transform.forward;
		gunLine.SetPosition (0, transform.position);

		if (Physics.Raycast (shootRay, out shootHit, range, shootableMask)) {
			//Hit an enemy goes here
			gunLine.SetPosition (1, shootHit.point);
		} else gunLine.SetPosition (1, shootRay.origin + shootRay.direction * range);

		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
