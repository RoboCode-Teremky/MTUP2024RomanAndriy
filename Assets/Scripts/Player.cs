using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float MoveSpeed = 5.0f;
    private int Hp = 5;

    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }
    public void Move(){
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x+MoveSpeed*Time.deltaTime, transform.position.y , transform.position.z);  
        }
    }
}
