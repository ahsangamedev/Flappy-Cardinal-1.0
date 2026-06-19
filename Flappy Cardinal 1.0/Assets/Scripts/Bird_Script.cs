using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Script : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStength;
    public LogicScript logic;

    public  bool birdIsALive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && birdIsALive)
        {
            myRigidbody.velocity = Vector2.up * flapStength;

        }

        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsALive = false;
    }

}
