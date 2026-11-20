using UnityEngine;

public class DuckSpawnerScript : MonoBehaviour
{
    public GameObject blackDuck;
    public GameObject redDuck;
    public GameObject blueDuck;


    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void SpawnDuck()
    {
        Vector3 spawnPos = new Vector3 (Random.Range(-7f,7f), 4, 12);
        //GameObject clone;
        //clone = Instantiate(duck, spawnPos, transform.rotation);
    }
}
