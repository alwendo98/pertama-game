using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{
    public int leftScore;
    public int rightScore;
    public int maxScore;
   
   public Ball ball;
    public void AddRightScore(int increment)
    {
        rightScore += increment;
        ball.ResetBall();

        if (rightScore >= maxScore)
        {
            Gameover();
        }

    }
    public void AddLeftScore(int increment)
    {
       leftScore += increment;
        ball.ResetBall();

        if (leftScore >= maxScore)
        {
            Gameover();
        }
    }

    public void Gameover()
    {
       SceneManager.LoadScene("Menu");
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
