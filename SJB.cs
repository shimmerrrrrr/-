using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SJB : MonoBehaviour
{
    public Sprite JD;
    public Sprite ST;
    public Sprite BU;

    public Text Score;
    public Image Player;
    public Image AI;
    public int PlayerScore = 0;
    public int AIScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = PlayerScore.ToString() + ":" + AIScore.ToString();
    }
    public void Call_ST()
    {
        Call(0);
    }
    public void Call_JD()
    {
        Call(1);
    }
    public void Call_BU()
    {
        Call(2);
    }
    public void Call(int i)
    {
        int ai = Random.Range(0, 3);
        Num2Img(ai, AI);
        Num2Img(i, Player);
        if(i==ai)
        {
            //Æ½¾Ö
        }
        else if(i==0)
        {
            if (ai == 1)
                PlayerScore++;
            if (ai == 2)
                AIScore++;
        }
        else if (i == 1)
        {
            if (ai == 2)
                PlayerScore++;
            if (ai == 0)
                AIScore++;
        }
        else if (i == 2)
        {
            if (ai == 0)
                PlayerScore++;
            if (ai == 1)
                AIScore++;
        }
    }
    public void Num2Img(int n,Image img)
    {
        switch(n)
        {
            case 0:img.sprite = ST;
                break;
            case 1:img.sprite = JD;
                break;
            case 2:img.sprite = BU;
                break;
        }
    }
}
