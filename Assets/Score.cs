using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;

    public static int highScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        SaveData data = SaveSystem.LoadPlayer();
        if (data != null)
        {
            highScore = data.highScore;
        }
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}
