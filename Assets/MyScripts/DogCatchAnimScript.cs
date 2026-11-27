using UnityEngine;

public class DogCatchAnimScript : MonoBehaviour
{
    DuckSpawnerScript ds;
    PlayerScript plr;
    void Start()
    {
        ds = GameObject.FindGameObjectWithTag("DuckSpawner").GetComponent<DuckSpawnerScript>();
        plr = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
    }

    
    void Update()
    {
        
    }
    void AllowDuckToSpawn()
    {
        plr.bullets = 3;
        ds.duckAllowedToSpawn = true;
    }
}
