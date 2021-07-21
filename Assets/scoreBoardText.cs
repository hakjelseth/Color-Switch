using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scoreBoardText : MonoBehaviour
{

   public Text currentScore;
   public Text highScore;

   public GameObject bronzeMedal;
   public GameObject silverMedal;
   public GameObject goldMedal;

   
   public void updateText()
   {
      if (Score.score > 10)
      {
         silverMedal.SetActive(true);
      }
      else if (Score.score > 20)
      {
         goldMedal.SetActive(true);
      }
      else
      {
         bronzeMedal.SetActive(true);
      }

      if (Score.score > Score.highScore)
      {
         SaveSystem.SaveGame(Score.score);
         Score.highScore = Score.score;
      }
      
      currentScore.text = Score.score.ToString();
      highScore.text = Score.highScore.ToString();

   }
}
