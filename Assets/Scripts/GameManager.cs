using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace willbeusingthat
{
public class GameManager : MonoBehaviour
{
   [SerializeField] private int score;
   [SerializeField] private GameObject gameOver;
   [SerializeField] private GameObject startScreen;
   
   
   
   
   private void Pause(){
    Time.timeScale = 0f;
   }
   
   
   
   
   private void Start() 
   {
    gameOver.SetActive(false);
    startScreen.SetActive(true);
    
    
    
    
   }
   private void DestroyStartText(){
    startScreen.SetActive(false);
   }


   private void Update() {
    if(Input.GetKeyDown(KeyCode.Space))
    {
        startScreen.SetActive(false);
    }
   }
   

   
   public Text scoreT;

   
   public void GameOver()
   {
    gameOver.SetActive(true);

    Pause();

   }
   public void Score()
   {
     score = score + 1;
     scoreT.text = score.ToString();   
    }
}
}
