﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1: MonoBehaviour {

	// Use this for initialization
	void Start () {
            int[] array = { 1, 3, 5, 8, 13 };
            for (int i = 0; i < array.Length; i++)
            {
                Debug.Log(array[i]);
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Debug.Log(array[i]);
            }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
