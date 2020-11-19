using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData {

    public double playedTime;

    public PlayerData (Player player)
    {
        playedTime = player.playedTime;
    }

}
