
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;
using Unity.VisualScripting;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameSO gameData;
    public PlayerScript plrScript;
    string strScore;
    public List<Image> imgList = new List<Image>();//6 total image object
    public List<Sprite> sprList = new List<Sprite>(); // 10 sprites avaliable

    
    void Update()
    {
        UIUpdate();
    }
    void UIUpdate()
    {       


        strScore = plrScript.score.ToString();

        int spriteIndex = 5;
        
        for (int i = 0; i < strScore.Length; i++)
        {
            
            int c = strScore[i] - '0';
            print(c);
            imgList[spriteIndex].sprite = sprList[c];

            spriteIndex--;
            //not finished
            /*
            foreach (char j in strScore)
            {
                print(j);
                imgList[i].sprite = sprList[j];
            }
            */
        }
        
        
        


    }
}
