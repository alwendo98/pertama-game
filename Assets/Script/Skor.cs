using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Skor : MonoBehaviour
{
   
   
    public int rightScore;
    public int leftScore;
     public int maxScore; 

    public Text skorKiri; 
    public Text skorKanan; 
     
  
     public void AddRightScore(int increment) 
    { 
         rightScore += increment; 
           if (rightScore >= maxScore) 
        { 
            GameOver(); 
        } 
        
    } 
 
    public void AddLeftScore(int increment) 
    { 
         leftScore += increment; 
         if (leftScore >= maxScore) 
        { 
            GameOver(); 
        } 
    } 
 
    public void GameOver() 
    { 
    } 

}
