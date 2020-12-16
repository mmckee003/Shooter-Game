using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public Text timeText;
    public float timer = 90f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeText.text = ((int)timer).ToString();
        if (timer>0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene(1);
        }

	}
}
