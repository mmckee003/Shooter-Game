using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject BulletPrefab;
	// Use this for initialization
	void Start () {
		
	}
    public float ForceValue = 100f;
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(BulletPrefab);
            bullet.transform.position = Camera.main.transform.position;
            bullet.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward* ForceValue);
            Destroy(bullet,5f);
        }
	}
}
