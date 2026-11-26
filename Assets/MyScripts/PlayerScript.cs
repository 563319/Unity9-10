
using UnityEngine;


public class PlayerScript : MonoBehaviour
{
    public GameObject cam;
    public int score;
    public LayerMask duckLayerMask;
    public GameSO gameData;
    int bullets = 3;

    RaycastHit hitCopy;

    void Start()
    {
        duckLayerMask = LayerMask.GetMask("Duck");
    }

    
    void Update()
    {
        
        if (bullets < 1)
        {
            //duck escape
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            //Touch touch = Input.GetTouch(0);
            if (bullets > 0)
            {
                Shoot();
            }
            Handheld.Vibrate();
        }
        
    }

   
    void Shoot()
    {
        /*
        //raycast
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
        */
        //sphere cast
        float thickness = 0.1f; //<-- Desired thickness here. //also radius
        float maxDist = 300;
        Vector3 origin = cam.transform.position;
        Vector3 direction = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        if (Physics.SphereCast(origin, thickness, direction, out hit, maxDist, duckLayerMask))
        {
            print("object: " + hit.collider.gameObject.name);
            var duck = hit.collider.gameObject.GetComponent<DuckScript>();
            if (duck.isDead == false)
            {
                duck.isDead = true;
                score += duck.scoreValue;
            }
            hitCopy = hit;
            
        }           
        
        
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(hitCopy.point, 0.1f);
    }
}
