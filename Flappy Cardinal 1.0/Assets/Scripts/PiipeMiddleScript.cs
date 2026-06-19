using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiipeMiddleScript : MonoBehaviour
{

    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        // So as soon as the new pipe spawns, it will look
        //  through the hirearchy to find a game boject with 
        // tag logic, then it will look through the object's 
        // component to to find the script of the class  
        // LogicScript  
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3) // checling if only the bird pass through we did this with the help of a layer
        {
            logic.addScore(1);
        }

    }

}
