using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text timer_text;
    public Text score_text;

    public static int current_score;
    private float timer = 60.0f;

    private bool timer_is_active;

    public EnemyCreater[] spawners;

    // Start is called before the first frame update
    void Start()
    {
        // disable enemy spawning
        foreach (EnemyCreater spawner in spawners)
        {
            spawner.enabled = false;
        }

        current_score = 0;
        timer_is_active = false;

        score_text.text = "Score: " + current_score;
        timer_text.text = "Timer: " + timer;
    }

    // Update is called once per frame
    void Update()
    {
        // update score
        score_text.text = "Score: " + current_score;

        if (Input.GetKeyDown(KeyCode.E))
        {
            timer_is_active = true;
            foreach (EnemyCreater spawner in spawners)
            {
                spawner.enabled = true;
            }
        }

        // update timer
        if (timer_is_active)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                SceneManager.LoadScene(1);
            }
        }

        timer_text.text = "Timer: " + (int) timer;
    }
}
