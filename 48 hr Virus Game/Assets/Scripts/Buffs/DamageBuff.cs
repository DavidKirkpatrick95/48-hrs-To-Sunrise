﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBuff : MonoBehaviour {




    public int amount;

    public void Activate(int damage)
    {
        amount = damage;
        GetComponent<Damage>().attackDamage += damage;
    }

    public void Deactivate()
    {
        GetComponent<Damage>().attackDamage -= amount;
    }
}
