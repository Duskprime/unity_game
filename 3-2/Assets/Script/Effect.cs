﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Destroy()
    {
        Destroy(gameObject);
    }

    void Uprising_Dest()
    {
        Destroy(gameObject, 0.5f);
    }
}
