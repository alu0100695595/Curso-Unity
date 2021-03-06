﻿using UnityEngine;
using System.Collections;

public class MovementPlatform : MonoBehaviour {

	private float useSpeed;
	public float directionSpeed = 9.0f;
	float origY;
	float origX;
	float origZ;
	public float distance = 10.0f;
	public bool vertical = true;
	public bool horizontal = true;
		
	// Use this for initialization
	void Start () 
	{
		origY = transform.position.y;
		origX = transform.position.x;
		origZ = transform.position.z;
		useSpeed = -directionSpeed;
	}
		
	// Update is called once per frame
	void Update ()
	{
				if (vertical == true) {
						if (origY - transform.position.y > distance) {
								useSpeed = directionSpeed; //flip direction
						} else if (origY - transform.position.y < -distance) {
								useSpeed = -directionSpeed; //flip direction
						}
						transform.Translate (0, useSpeed * Time.deltaTime, 0);
				} else if (horizontal == true) {
						if (origX - transform.position.x > distance) {
								useSpeed = directionSpeed; //flip direction
						} else if (origX - transform.position.x < -distance) {
								useSpeed = -directionSpeed; //flip direction
						}
				
						transform.Translate (useSpeed * Time.deltaTime, 0, 0);
				} else {
					if (origZ - transform.position.z > distance) {
						useSpeed = directionSpeed; //flip direction
					} else if (origZ - transform.position.z < -distance) {
						useSpeed = -directionSpeed; //flip direction
					}
					transform.Translate (0, 0, useSpeed * Time.deltaTime);

				}
				
		}
}
