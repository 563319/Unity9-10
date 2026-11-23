using System.Collections;
using TMPro;
using UnityEngine;


public class DuckScript : MonoBehaviour
{
    public bool isDead = false;
    public string colour;//black red blue
    float speed;
    float flightDuration = 5; //seconds
    public Rigidbody rb;
    public SpriteRenderer spr;
    public Animator anim;
    public SphereCollider sphereCol;
    public Vector3 fallPosition;//for the dog
    public GameSO gameData;
    public int scoreValue;
    public GameObject scoreText;
    bool canCallShot = true;
    void Start()
    {
        if (colour == "black")
        {
            speed = 4;
        }
        if (colour == "blue")
        {
            speed = 5;
        }
        if (colour == "red")
        {
            speed = 7;
        }
        rb.linearVelocity = GetRandomDirection() * speed;

        if (gameData.round > 0 && gameData.round < 6)
        {
            if (colour == "black")
            {
                scoreValue += 500;
            }
            if (colour == "blue")
            {
                scoreValue += 1000;
            }
            if (colour == "red")
            {
                scoreValue += 1500;
            }
        }
        if (gameData.round > 5 && gameData.round < 11)
        {
            if (colour == "black")
            {
                scoreValue += 800;
            }
            if (colour == "blue")
            {
                scoreValue += 1600;
            }
            if (colour == "red")
            {
                scoreValue += 2400;
            }
        }
        if (gameData.round > 11)
        {
            if (colour == "black")
            {
                scoreValue += 1000;
            }
            if (colour == "blue")
            {
                scoreValue += 2000;
            }
            if (colour == "red")
            {
                scoreValue += 3000;
            }
        }
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
            
        }
        else
        {
            
            //duck has died so play death animation stuff
            //show shot anim wait then go down and play dead anim
            
            if (canCallShot == true)
            {
               Shot();
            }
            
            //Fall();
            sphereCol.enabled = false;
            if (transform.position.y <= 4.5)
            {
                fallPosition = transform.position;
                Destroy(gameObject);
            }
        }

    }
    
    void Shot()
    {
        canCallShot = false;
        rb.linearVelocity = Vector3.zero;
        anim.SetBool("isShot", true);
        //wait a second then call fall

        StartCoroutine(Fall(1));
    }
    IEnumerator Fall(int secs)
    {
        yield return new WaitForSeconds(secs);
        StartCoroutine(spawnScoreIndicator(0.2f));
        anim.SetBool("isDead", true);
        rb.linearVelocity = new Vector3(0,-3f,0);
        //fall down velocity
    }
   IEnumerator spawnScoreIndicator(float secs)
   {
        yield return new WaitForSeconds(secs);
        Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
        GameObject clone;
        clone = Instantiate(scoreText, spawnPos, transform.rotation);
        clone.GetComponent<TextMeshPro>().text = "" + scoreValue;//not gui text mesh pro as the prefab uses tmp
        Destroy(clone, 1f);
   }

    
    private void OnCollisionEnter(Collision col)
    {
        if (!isDead)
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
        }
        
    }




    public Vector2 GetRandomDirection()
    {
        // Define the ranges of angles in degrees to avoid straight up and down directions.
        float minAngle1 = 20f;//120
        float maxAngle1 = 70f;//240
        float minAngle2 = 200f;//60
        float maxAngle2 = 250f;//300
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
