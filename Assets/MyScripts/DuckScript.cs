using UnityEngine;

public class DuckScript : MonoBehaviour
{
    bool isDead = false;
    public string colour;//black red blue
    float speed;
    float flightDuration = 5; //seconds
    public Rigidbody rb;
    public SpriteRenderer spr;
    void Start()
    {
        if (colour == "black")
        {
            speed = 4;
        }
        else if (colour == "blue")
        {
            speed = 8;
        }
        else //colour == red //
        {
            speed = 12;
        }
        rb.linearVelocity = GetRandomDirection() * speed;
    }

    
    void Update()
    {
       
        if (isDead == false)
        {
            //fly around until player misses 3 shots or player shoots duck
            if (rb.linearVelocity.x > 0)
            {
                spr.flipX = false;
            }
            if (rb.linearVelocity.x < 0)
            {
                spr.flipX = true;
            }
            /*
            if (rb.linearVelocity.x == 0)
            {
                rb.linearVelocity = new Vector3(Random.Range(1,3), rb.linearVelocity.y, 0);
            }
            if (rb.linearVelocity.y == 0)
            {
                rb.linearVelocity = new Vector3(rb.linearVelocity.x, Random.Range(1,3), 0);
            }
            */
        }
        else
        {
            //duck has died so play death animation stuff
            //show shot anim wait then go down and play dead anim
            //Shot();
            //Fall();
        }

    }
    
    void Shot()
    {

    }
    void Fall()
    {

    }
    
    private void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.CompareTag("BoundaryWall"))
        {
            //reverse x
            Debug.Log("trying to reverse x");
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y, 0);
            Debug.Log("X vel: " + rb.linearVelocity.x);
        }
        if (col.gameObject.CompareTag("BoundaryFloor"))
        {
            //reverse y
            Debug.Log("trying to reverse y");
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y, 0);
            Debug.Log("Y vel: " + rb.linearVelocity.y);
        }
        
        /*
        if (col.gameObject.CompareTag("Boundary"))
        {
            Debug.Log("COLLISION WITH WALL!!!!");
            
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, -rb.linearVelocity.y, 0);
        }
        */
    }




    public Vector2 GetRandomDirection()
    {
        // Define the ranges of angles in degrees to avoid straight up and down directions.
        float minAngle1 = 120f;
        float maxAngle1 = 240f;
        float minAngle2 = 60f;
        float maxAngle2 = 300f;
        // Choose a random angle from either range 1 or range 2.
        float randomAngle;
        if (Random.value < 0.5f)
        {
            // Pick from first range (120 to 240 degrees)
            randomAngle = Random.Range(minAngle1, maxAngle1);
        }
        else
        {
            // Pick from second range (60 to 300 degrees)
            randomAngle = Random.Range(minAngle2, maxAngle2);
        }
        // Convert the random angle to radians since Mathf functions expect radians.
        float radians = randomAngle * Mathf.Deg2Rad;
        // Create a Vector2 direction using the cosine and sine of the angle.
        Vector2 direction = new Vector2(Mathf.Cos(radians), Mathf.Sin(radians));
        // Normalize the vector to ensure it's a unit vector (magnitude of 1).
        return direction.normalized;
    }
}
