using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreater : MonoBehaviour {
  public  Vector3 P1, P2;
    public GameObject EnemyPrefab;
    
    public int cont; 
    private void Awake()
    {
        P1 = transform.GetChild(0).position;
        P2 = transform.GetChild(1).position;
    }
    // Use this for initialization
    void Start () {
		
	}
    float timer=5f;
	// Update is called once per frame
	void Update () {
        if (timer>=2f&&cont<10)
        {
            timer = 0f;
            var enemy= Instantiate(EnemyPrefab);
            var lerpvalue = Random.Range(0f, 1f);
            enemy.transform.position = Vector3.Lerp(P1,P2,lerpvalue);
            enemy.transform.position = new Vector3(enemy.transform.position.x + Random.Range(-5, 5), enemy.transform.position.y, enemy.transform.position.z);
            enemy.GetComponent<Enemy>().enemyCreater = this;
        }
        else
        {
            timer += Time.deltaTime;
        }
	}
}
