using UnityEngine;
using UnityEngine.UI;
public class DuckUIScript : MonoBehaviour
{
    public Image UIimg;
    public PlayerScript plr;

    public Sprite zeroDucks;
    public Sprite oneDuck;
    public Sprite twoDucks;
    public Sprite threeDucks;
    public Sprite fourDucks;
    public Sprite fiveDucks;
    public Sprite sixDucks;
    public Sprite sevenDucks;
    public Sprite eightDucks;
    public Sprite nineDucks;
    public Sprite tenDucks;

    
    void Update()
    {
        UIUpdate();
    }
    void UIUpdate()
    {
        if (plr.ducksShot == 0)
        {
            UIimg.sprite = zeroDucks;
        }
        if (plr.ducksShot == 1)
        {
            UIimg.sprite = oneDuck;
        }
        if (plr.ducksShot == 2)
        {
            UIimg.sprite = twoDucks;
        }
        if (plr.ducksShot == 3)
        {
            UIimg.sprite = threeDucks;
        }
        if (plr.ducksShot == 4)
        {
            UIimg.sprite = fourDucks;
        }
        if (plr.ducksShot == 5)
        {
            UIimg.sprite = fiveDucks;
        }
        if (plr.ducksShot == 6)
        {
            UIimg.sprite = sixDucks;
        }
        if (plr.ducksShot == 7)
        {
            UIimg.sprite = sevenDucks;
        }
        if (plr.ducksShot == 8)
        {
            UIimg.sprite = eightDucks;
        }
        if (plr.ducksShot == 9)
        {
            UIimg.sprite = nineDucks;
        }
        if (plr.ducksShot == 10)
        {
            UIimg.sprite = tenDucks;
        }

    }
}
