
using UnityEngine;


public class PlayerScript : MonoBehaviour
{
    int score;
    public LayerMask duckLayerMask;
    public GameSO gameData;
    int bullets = 3;

    void Start()
    {
        duckLayerMask = LayerMask.GetMask("Duck");
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (bullets > 0)
            {
                Shoot();
            }
            
        }
        if (bullets < 1)
        {
            //duck escape
        }
    }

   
    void Shoot()
    {
        bullets -= 1;
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100f, duckLayerMask))
        {
            print("object: " + hit.collider.gameObject.name);
            var duck = hit.collider.gameObject.GetComponent<DuckScript>();
            duck.isDead = true;
            score += duck.scoreValue;
        }               
    }
}
