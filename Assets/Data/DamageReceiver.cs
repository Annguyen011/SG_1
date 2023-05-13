using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    public int hp = 10;
    public bool IsDead()
    {
        return hp <= 0;
    }
    public virtual void Receiver(int dmg)
    {
        hp-=dmg;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
