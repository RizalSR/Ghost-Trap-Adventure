using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        //ScoreTextScripts.coinAmount += 1;
        Destroy (gameObject);
    }
}
