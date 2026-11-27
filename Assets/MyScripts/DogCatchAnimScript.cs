using UnityEngine;

public class DogCatchAnimScript : MonoBehaviour
{
    public DuckSpawnerScript ds;
    void Start()
    {
        ds = GameObject.FindGameObjectWithTag("DuckSpawner").GetComponent<DuckSpawnerScript>();
    }

    
    void Update()
    {
        
    }
    void AllowDuckToSpawn()
    {
        ds.duckAllowedToSpawn = true;
    }
}
