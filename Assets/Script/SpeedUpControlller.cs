using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpControlller : MonoBehaviour
{
    public PowerUpManajer manajer;
    public Collider2D Ball;
    public float magnitude;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == Ball)
        {
            Ball.GetComponent<Ball>().ActivateSpeedUp(magnitude);
            manajer.RemovePowerUp(gameObject);
        }
    }
}
