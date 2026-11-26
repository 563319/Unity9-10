using UnityEngine;
using UnityEngine.UI;

public class RoundUIScript : MonoBehaviour
{
    public GameSO gameData;
    

    //left num defualt pos = 12.46914,0,0     sacle: 1,1,1
    //right num defualt pos = 37.53087 etc
    public Image leftnumImg;
    public Image rightnumImg;

    public Sprite zero;
    public Sprite one;
    public Sprite two;
    public Sprite three;
    public Sprite four;
    public Sprite five;
    public Sprite six;
    public Sprite seven;
    public Sprite eight;
    public Sprite nine;
    public Sprite blank;
    

    string strRound;
    char firstLetter;
    char secondLetter;
    void Update()
    {
        UIUpdate();
    }
    void UIUpdate()
    {
        strRound = gameData.round.ToString();
        
        if (strRound.Length == 1)
        {
            rightnumImg.sprite = blank;
            firstLetter = strRound[0];
            //first digit
            if (firstLetter == '0')
            {
                leftnumImg.sprite = zero;
            }
            if (firstLetter == '1')
            {
                leftnumImg.sprite = one;
            }
            if (firstLetter == '2')
            {
                leftnumImg.sprite = two;
            }
            if (firstLetter == '3')
            {
                leftnumImg.sprite = three;
            }
            if (firstLetter == '4')
            {
                leftnumImg.sprite = four;
            }
            if (firstLetter == '5')
            {
                leftnumImg.sprite = five;
            }
            if (firstLetter == '6')
            {
                leftnumImg.sprite = six;
            }
            if (firstLetter == '7')
            {
                leftnumImg.sprite = seven;
            }
            if (firstLetter == '8')
            {
                leftnumImg.sprite = eight;
            }
            if (firstLetter == '9')
            {
                leftnumImg.sprite = nine;
            }
            
        }

        if (strRound.Length > 1)
        {
            firstLetter = strRound[0];
            secondLetter = strRound[1];
            //first digit
            if (firstLetter == '0')
            {
                leftnumImg.sprite = zero;
            }
            if (firstLetter == '1')
            {
                leftnumImg.sprite = one;
            }
            if (firstLetter == '2')
            {
                leftnumImg.sprite = two;
            }
            if (firstLetter == '3')
            {
                leftnumImg.sprite = three;
            }
            if (firstLetter == '4')
            {
                leftnumImg.sprite = four;
            }
            if (firstLetter == '5')
            {
                leftnumImg.sprite = five;
            }
            if (firstLetter == '6')
            {
                leftnumImg.sprite = six;
            }
            if (firstLetter == '7')
            {
                leftnumImg.sprite = seven;
            }
            if (firstLetter == '8')
            {
                leftnumImg.sprite = eight;
            }
            if (firstLetter == '9')
            {
                leftnumImg.sprite = nine;
            }
            //second digit
            if (secondLetter == '0')
            {
                rightnumImg.sprite = zero;
            }
            if (secondLetter == '1')
            {
                rightnumImg.sprite = one;
            }
            if (secondLetter == '2')
            {
                rightnumImg.sprite = two;
            }
            if (secondLetter == '3')
            {
                rightnumImg.sprite = three;
            }
            if (secondLetter == '4')
            {
                rightnumImg.sprite = four;
            }
            if (secondLetter == '5')
            {
                rightnumImg.sprite = five;
            }
            if (secondLetter == '6')
            {
                rightnumImg.sprite = six;
            }
            if (secondLetter == '7')
            {
                rightnumImg.sprite = seven;
            }
            if (secondLetter == '8')
            {
                rightnumImg.sprite = eight;
            }
            if (secondLetter == '9')
            {
                rightnumImg.sprite = nine;
            }
        }

    }
}
