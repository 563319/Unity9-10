using UnityEngine;

public class BulletUIScript : MonoBehaviour
{

    public GameObject cover1;
    public GameObject cover2;
    public GameObject cover3;
    public PlayerScript plrScript;
    void Update()
    {
        UIUpdate();
    }  
    void UIUpdate()
    {
        if (plrScript.bullets == 3)
        {
            cover3.SetActive(false);
            cover2.SetActive(false);
            cover1.SetActive(false);

        }
        if (plrScript.bullets == 2)
        {
            cover3.SetActive(true);
            cover2.SetActive(false);
            cover1.SetActive(false);
        }
        if (plrScript.bullets == 1)
        {
            cover3.SetActive(true);
            cover2.SetActive(true);
            cover1.SetActive(false);
        }
        if (plrScript.bullets <= 0)
        {
            cover3.SetActive(true);
            cover2.SetActive(true);
            cover1.SetActive(true);
        }


    }
}
