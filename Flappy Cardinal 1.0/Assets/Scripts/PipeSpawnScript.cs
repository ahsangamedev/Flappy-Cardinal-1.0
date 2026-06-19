
using UnityEngine;



public class PipeSpawnScript : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 2; // how many seconds it should be between spawns 
    private float timer = 0;
    public float hightOffset = 10;


    // Start is called before the first frame update
    void Start()
    {
        Spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {


        if(timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            Spawnpipe();
            timer = 0;
        }

        /* 
            so every frame it asks if the timer is less than 
            the spawn rate if it is, then count the timer up
            if not the timer actually met or exceeded the spawn rate
            then spawn the pipe and start hte time again
        */


    }



    void Spawnpipe()
    {

        float lowestPoint = transform.position.y - hightOffset;
        float highestPoint = transform.position.y + hightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    } 


}

