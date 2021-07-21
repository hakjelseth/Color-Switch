using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class SaveData
{
    public int highScore;

    public SaveData (int score)
    {
        highScore = score;
    }
}
