using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DemoEnd : MonoBehaviour {
    public Text score;

	// Use this for initialization
	void Start () {
        score.text ="Score:"+  UIManager.current_score;
	}
	public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Application.Quit();
    }

	// Update is called once per frame
	void Update () {
		
	}
}
