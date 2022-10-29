using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{ 
    public Vector2 speed; 
  public KeyCode upKey; 
    public KeyCode downKey; 
  private Rigidbody2D rig; 
    private void Start() 
    { 
       rig = GetComponent<Rigidbody2D>(); 
    } 
    private void MoveObject(Vector2 movement) 
   { 
    rig.velocity = movement; 
    } 
  private Vector2 GetInput() 
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        { 
           return Vector2.up * speed; 
        }    
          else if (Input.GetKey(KeyCode.DownArrow))
          {
            return Vector2.down * speed; 
          }
         
        return Vector2.zero; 
    } 
    private void Update() 
    { 
       
    } 
}
