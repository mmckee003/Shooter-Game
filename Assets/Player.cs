﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject BulletPrefab;

    public int MaxBulletCount = 10;
    public int CurrBulletCount;

	// Use this for initialization
	void Start () {
        CurrBulletCount = 10;
	}
    public float ForceValue = 100f;
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            if (CurrBulletCount > 0)
            {
                var bullet = Instantiate(BulletPrefab);
                bullet.transform.position = Camera.main.transform.position;
                bullet.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * ForceValue);
                Destroy(bullet, 5f);
                CurrBulletCount--;
            }
        }

        // reload gun
        if (Input.GetKeyDown(KeyCode.R))
        {
            CurrBulletCount = MaxBulletCount;
        }

        // Close application when ESC is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }
    }
}
