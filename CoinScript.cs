﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

     void OnTriggerEnter2D(Collider2D col)
    {
        ScoreScript.scoreValue += 1;
        SoundManagerScript.PlaySound("Coin");
        Destroy(gameObject);
    }

}
