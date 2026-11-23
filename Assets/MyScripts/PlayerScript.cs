using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerScript : MonoBehaviour
{
    int score;
    public LayerMask duckLayerMask;
    public GameSO gameData;

    void Start()
    {
        duckLayerMask = LayerMask.GetMask("Duck");
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

   
    void Shoot()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100f, duckLayerMask))
        {
            print("object: " + hit.collider.gameObject.name);
            var duck = hit.collider.gameObject.GetComponent<DuckScript>();
            duck.isDead = true;

            if (gameData.round > 0 &&  gameData.round < 6)
            {
                if (duck.colour == "black")
                {
                    score += 500;
                }
                if (duck.colour == "blue")
                {
                    score += 1000;
                }
                if (duck.colour == "red")
                {
                    score += 1500;
                }
            }
            if (gameData.round > 5 && gameData.round < 11)
            {
                if (duck.colour == "black")
                {
                    score += 800;
                }
                if (duck.colour == "blue")
                {
                    score += 1600;
                }
                if (duck.colour == "red")
                {
                    score += 2400;
                }
            }
            if (gameData.round > 11)
            {
                if (duck.colour == "black")
                {
                    score += 1000;
                }
                if (duck.colour == "blue")
                {
                    score += 2000;
                }
                if (duck.colour == "red")
                {
                    score += 3000;
                }
            }


        }
        
    }
    
}
