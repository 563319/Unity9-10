
using UnityEngine;
using System.Collections;

public class DuckSpawnerScript : MonoBehaviour
{
    public GameObject blackDuck;
    public GameObject redDuck;
    public GameObject blueDuck;

    public GameSO gameData;

 
    public bool duckAllowedToSpawn = false;
    int ducksSpawnedSinceRoundStart = 0;
    
    //10 ducks per round 
    void Start()
    {
        
    }

    void Update()
    {
        if (duckAllowedToSpawn == true && ducksSpawnedSinceRoundStart < 10)
        {
            //StartCoroutine(SpawnDuck(1));
            SpawnDuck();
            
        }
    }

    //
    /*

    what i need to do:

    make a bool "duckAllowedToSpawn" set it false after spawning a duck

    when a duck escape anim (   bird escapes - change sky color and make duck leave screen by anim -> )or dog showing the duck caught anim ends it 
    triggers a func that sets duckAllowedToSpawn to true

    round system will work in a similar way
    add duck escape anim

   stop the player being able to shoot inbetween duck spawns

    mabye make sprites for dog holding other color of duck

    ***got to do bullet ui aswell, just disable/enable a object based on bullets fired
    */
    //

    void SpawnDuck()
    {

        //yield return new WaitForSeconds(secs);
        duckAllowedToSpawn = false;
        ducksSpawnedSinceRoundStart += 1;
        int randNum = Random.Range(1,11);
        Vector3 spawnPos = new Vector3 (Random.Range(-7f,8f), 5f, 12);
        GameObject clone;
        //choose duck color based on round count and chance   
        if (gameData.round == 1)
        {
            if (randNum == 1)
            {
                clone = Instantiate(blackDuck, spawnPos, transform.rotation);//black
            }
            if (randNum == 2)
            {
                clone = Instantiate(blackDuck, spawnPos, transform.rotation);//black
            }
            if (randNum == 3)
            {
                clone = Instantiate(blackDuck, spawnPos, transform.rotation);//black
            }
            if (randNum == 4)
            {
                clone = Instantiate(blackDuck, spawnPos, transform.rotation);//black
            }
            if (randNum == 5)
            {
                clone = Instantiate(blackDuck, spawnPos, transform.rotation);//black
            }
            if (randNum == 6)
            {
                clone = Instantiate(blackDuck, spawnPos, transform.rotation);//black
            }
            if (randNum == 7)
            {
                clone = Instantiate(blackDuck, spawnPos, transform.rotation);//black
            }
            if (randNum == 8)
            {
                clone = Instantiate(blackDuck, spawnPos, transform.rotation);//black
            }
            if (randNum == 9)
            {
                clone = Instantiate(blueDuck, spawnPos, transform.rotation);//blue
            }
            if (randNum == 10)
            {
                clone = Instantiate(blueDuck, spawnPos, transform.rotation);//blue
            }
        }
        if (gameData.round > 1)
        {
            if (randNum == 1)
            {
                clone = Instantiate(blackDuck, spawnPos, transform.rotation);//black
            }
            if (randNum == 2)
            {
                clone = Instantiate(redDuck, spawnPos, transform.rotation);//red
            }
            if (randNum == 3)
            {
                clone = Instantiate(blueDuck, spawnPos, transform.rotation);//blue
            }
            if (randNum == 4)
            {
                clone = Instantiate(blueDuck, spawnPos, transform.rotation);//blue
            }
            if (randNum == 5)
            {
                clone = Instantiate(blackDuck, spawnPos, transform.rotation);//black
            }
            if (randNum == 6)
            {
                clone = Instantiate(blackDuck, spawnPos, transform.rotation);//black
            }
            if (randNum == 7)
            {
                clone = Instantiate(blackDuck, spawnPos, transform.rotation);//black
            }
            if (randNum == 8)
            {
                clone = Instantiate(blackDuck, spawnPos, transform.rotation);//black
            }
            if (randNum == 9)
            {
                clone = Instantiate(blackDuck, spawnPos, transform.rotation);//black
            }
            if (randNum == 10)
            {
                clone = Instantiate(blackDuck, spawnPos, transform.rotation);//black
            }

        }

    }
}
