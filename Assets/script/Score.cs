using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text_score,count_down_txt,highscore_txt;
    private int y=0,h=0;




    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(count_down());
        h=PlayerPrefs.GetInt("high_score");
        highscore_txt.text="high-"+Convert.ToString(h);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator score_increament()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.5f);
            y++;
            text_score.text=Convert.ToString(y);
            
            if(h<=y)
            {
                h=y;
            }
            PlayerPrefs.SetInt("high_score",h);
            highscore_txt.text="high-"+Convert.ToString(h);
        }
    }


    IEnumerator count_down()
    {
        int i=3;
        while(i>=0)
        {
            if(i<1)
            {
                count_down_txt.text="Go";
            }
            else
            {
                count_down_txt.text=i.ToString();
            }
            yield return new WaitForSeconds(1);
            i--;
        }

        Destroy(count_down_txt);

        StartCoroutine(score_increament());
        

    }



}
