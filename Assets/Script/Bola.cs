using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball1 : MonoBehaviour
{
   public float StartSpeed;
   public float extraSpeed;
   public float maxExtraSpeed;

   private int hitCounter = 0;

   private Rigidbody2D rb;

   //Start is called before the first frame update
   void Start()
   {
    rb = GetComponent<Rigidbody2D>();

    StartCoroutine(Launch());
   }

   public IEnumerator Launch()
   {
    hitCounter =0;
    yield return new WaitForSeconds(1);

    MoveBall(new Vector2(-1, 0));
   }

   public void MoveBall(Vector2 direction)
   {
    direction = direction.normalized;

    float ballSpeed = StartSpeed + hitCounter * extraSpeed;

    rb.velocity = direction * ballSpeed;
   }

   public void InCreaseHitCounter()
   {
      if(hitCounter * extraSpeed < maxExtraSpeed)
      {
         hitCounter++;
      }
   }
}
