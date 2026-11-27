using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BlueBarUIScript : MonoBehaviour
{

   
    public GameSO gd;

    public GameObject img1;
    public GameObject img2;
    public GameObject img3;
    public GameObject img4;
    public GameObject img5;
    public GameObject img6;
    public GameObject img7;
    public GameObject img8;
    public GameObject img9;
    public GameObject img10;

    /*
    duck quota
    round min
    1-10     6/10
    11-12    7/10
    13-14    8/10
    15-19    9/10
    20+      10/10
    */

    void Update()
    {
        UIUpdate();
    }
    void UIUpdate()
    {
        //print("gd.round " + gd.round);
        if (gd.round <= 10)
        {
            img1.SetActive(true);
            img2.SetActive(true);
            img3.SetActive(true);
            img4.SetActive(true);
            img5.SetActive(true);
            img6.SetActive(true);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
            img9.SetActive(false);
        }
        if (gd.round == 11 || gd.round == 12)
        {
            img1.SetActive(true);
            img2.SetActive(true);
            img3.SetActive(true);
            img4.SetActive(true);
            img5.SetActive(true);
            img6.SetActive(true);
            img7.SetActive(true);
            img8.SetActive(false);
            img9.SetActive(false);
            img9.SetActive(false);

        }
        if (gd.round == 13 || gd.round == 14)
        {
            img1.SetActive(true);
            img2.SetActive(true);
            img3.SetActive(true);
            img4.SetActive(true);
            img5.SetActive(true);
            img6.SetActive(true);
            img7.SetActive(true);
            img8.SetActive(true);
            img9.SetActive(false);
            img9.SetActive(false);
        }
        if (gd.round >= 15 && gd.round <= 19)
        {
            img1.SetActive(true);           
            img2.SetActive(true);
            img3.SetActive(true);
            img4.SetActive(true);
            img5.SetActive(true);
            img6.SetActive(true);
            img7.SetActive(true);       
            img8.SetActive(true);
            img9.SetActive(true);
            img10.SetActive(false);
        }
        if (gd.round >= 20)
        {
            img1.SetActive(true);
            img2.SetActive(true);
            img3.SetActive(true);
            img4.SetActive(true);
            img5.SetActive(true);
            img6.SetActive(true);
            img7.SetActive(true);
            img8.SetActive(true);
            img9.SetActive(true);
            img10.SetActive(true);
        }
    }
}
