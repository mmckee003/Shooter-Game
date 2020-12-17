using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public EnemyCreater enemyCreater;
	// Use this for initialization
	void Start () {
        enemyCreater.count ++;
        var destroytimer = Random.Range(5f, 10f);
        Destroy(gameObject,destroytimer);
        StartCoroutine(EnemyMove());
    }
    public void OnDamage()
    {
        Destroy(gameObject);
    }
    private void OnDestroy()
    {
        enemyCreater.count --;
    }
    public float MoveSpeed=3f;
	IEnumerator EnemyMove()
    {
        while (Vector3.Distance(transform.position,enemyCreater.P1)>0.5f)
        {
            transform.position = Vector3.MoveTowards(transform.position,enemyCreater.P1,MoveSpeed*Time.deltaTime);
            yield return null;
        }

        while (Vector3.Distance(transform.position, enemyCreater.P2) > 0.5f)
        {
            transform.position = Vector3.MoveTowards(transform.position, enemyCreater.P2, MoveSpeed*Time.deltaTime);
            yield return null;
        }
        StartCoroutine(EnemyMove());
    }
    // Update is called once per frame
    void Update () {
		
	}
}
