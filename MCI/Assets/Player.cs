using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
    public double playedTime;

    void Start()
    {
        playedTime = 0.0;
    }

    void Update()
    {
        playedTime += Time.deltaTime;
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
}
