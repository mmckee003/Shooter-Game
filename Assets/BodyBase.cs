using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyBase : MonoBehaviour {


public virtual void Hurt() {
        GetComponentInParent<Enemy>().OnDamage();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Bullet")
        {
            print("hit");
            Hurt();
        }
    }
}
