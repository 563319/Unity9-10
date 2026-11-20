using NUnit.Framework;
using UnityEngine;

public class DuckSpawnerScript : MonoBehaviour
{
    public GameObject blackDuck;
    public GameObject redDuck;
    public GameObject blueDuck;

    public GameSO gameData;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void SpawnDuck()
    {
        int randNum = Random.Range(0,10);
        Vector3 spawnPos = new Vector3 (Random.Range(-7f,7f), 4, 12);
        GameObject clone;
        if (gameData.round == 1)
        {
            clone = Instantiate(blackDuck, spawnPos, transform.rotation);
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

        }

    }
}
