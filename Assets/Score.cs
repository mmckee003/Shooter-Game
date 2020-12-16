using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    public static int score;
    private void Awake()
    {
        score = 0;
    }
    private void OnGUI()
    {
        GUI.color = Color.green;
        GUILayout.Label("Score:"+score);
    }
}
