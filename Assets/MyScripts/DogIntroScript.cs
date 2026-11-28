using UnityEngine;

public class DogIntroScript : MonoBehaviour
{
    public PlayerScript plr;
    public DuckSpawnerScript dss;
    public Animator anim;

    public void AnimOFF()
    {
        anim.SetBool("active", false);
    }
    public void AnimON()
    {
        anim.SetBool("active", true);
    }
    public void StartRound()
    {
        dss.duckAllowedToSpawn = true;
        plr.allowedToShoot = true;
        AnimOFF();
    }
}
