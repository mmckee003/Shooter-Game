using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoHUD : MonoBehaviour
{
    public Player player;
    public Text ammo_count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ammo_count.text = "Ammo: " + player.current_bullet_count;
    }
}
