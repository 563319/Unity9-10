using System.Collections.Generic;
using UnityEngine;
public class DuckUIScript : MonoBehaviour
{
    public PlayerScript plr;
    public DuckSpawnerScript dss;

    public List<GameObject> redDucks = new List<GameObject>();
 

    void Start()
    {

    }
    
    
    void Update()
    {
        //dss.ducksSpawnedSinceRoundStart
       //i need to switch to 1 sprite for each duck
       //duck1.SetActive(true);
        UIUpdate();
    }
    void UIUpdate()
    {
        /*
        for (int i=0; i<redDucks.Count; i++)
        {
            if (i == dss.ducksSpawnedSinceRoundStart-1)
            {
                
            }
        }
        */

    }
    public void AddDuckKill(int id)
    {
        redDucks[id-1].SetActive(true);
    }
    public void ResetDuckUI()
    {
        for (int i=0; i<redDucks.Count; i++)
        {
            redDucks[i].SetActive(false);
        }
    }
}
