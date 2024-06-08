using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float MoveSpeed = 5.0f;
    private int Hp = 5;
    public MoveSpeed ms;
    private GameObject gameObject;
    void Start()
    {
        Move();
    }

    void Update()
    {
        
    }
    public void Move(){
        if(GetButtonDown<"W">())
        {transform.position = new Vector3(transform.position.x++ , transform.position.y , transform.position.z);
            
        }
    }
}
