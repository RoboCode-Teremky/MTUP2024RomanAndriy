using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed = 5.0f;
    public int Hp = 5;
    public float HighJump = 10.0f;

    void Start()
    {
        
    }

    void Update()
    { 
        Move();
      float x = Input.GetAxis("Horizontal");
      float y = Input.GetAxis("Vertical");
      Vector3 movement = new Vector3(x, 0 , y);
      transform.Translate(movement*MoveSpeed*Time.deltaTime);
    }
    public void Move(){
      if(Input.GetKeyDown(KeyCode.Space))
      {
          transform.position = new Vector3(transform.position.x, transform.position.y+HighJump*MoveSpeed*Time.deltaTime, transform.position.z);  
      }  }
}
