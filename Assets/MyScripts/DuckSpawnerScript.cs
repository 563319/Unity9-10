
using UnityEngine;

public class DuckSpawnerScript : MonoBehaviour
{
    public GameObject blackDuck;
    public GameObject redDuck;
    public GameObject blueDuck;

    public GameSO gameData;

    bool aDuckIsActive = false;
    int ducksSpawnedSinceRoundStart = 0;
    void Start()
    {
        
    }

    void Update()
    {
        if (aDuckIsActive == false)
        {
            SpawnDuck();
            aDuckIsActive = true; //reminder// when the player hits or misses 3 shots, this should become false
        }
    }

    //
    /*

    what i need to do:

    make a bool "duckAllowedToSpawn" set it false after spawning a duck

    when a duck escape anim or dog showing the duck caught anim ends it 
    triggers a func that sets duckAllowedToSpawn to true

    round system will work in a similar way

    ***got to do bullet ui aswell, just disable/enable a object based on bullets fired
    */
    //
    void SpawnDuck()
    {
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
