using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
   public  Vector2 speed;
   public Vector2 resetPosition;
   public GameObject goalEffect;

   private Rigidbody2D rig; 
    
    private void Start()
    {
         rig = GetComponent<Rigidbody2D>(); 
        rig.velocity = speed; 
    }
    public void ResetBall()
    {
      transform.position = new Vector3(resetPosition.x, resetPosition.y,2);
      Instantiate(goalEffect, this.transform.position, Quaternion.identity);
    
    }
   
   public void ActivateSpeedUp(float magnitude)
   {
    rig.velocity *= magnitude;
    Instantiate(goalEffect, this.transform.position, Quaternion.identity);
   
   }

   
    
}
