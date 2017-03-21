using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour {

	private int count;
	private int timer;

	private GameObject water;

	void Start () {
		water = GameObject.FindGameObjectWithTag ("RushingWater");

		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		for (int i; i <= 1000; i++) {
			count += 1;
		}
		//turn rushing water to visiable every 20 frames

		
	}
}
