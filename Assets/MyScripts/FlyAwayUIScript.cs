using UnityEngine;

public class FlyAwayUIScript : MonoBehaviour
{
    public Animator anim;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    void EndAnim()
    {
        anim.SetBool("active", false);
    }
}
