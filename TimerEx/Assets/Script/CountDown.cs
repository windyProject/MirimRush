using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    float LimitTime = 91f;
    public Text TimeText;
    void Update()
    {
        LimitTime -= Time.deltaTime;

        if (LimitTime >= 0)
        {

            if (LimitTime >= 60f)
            {
                int b = (int)LimitTime - 60;
                if (b < 10)
                    TimeText.text = "1 : " + "0" + b;
                else
                    TimeText.text = "1 : " + b;
            }
            else
            {
                int b = (int)LimitTime;
                //TimeText.text = b.ToString();
                if (b < 10)
                    TimeText.text = "0 : 0" + b;
                else
                    TimeText.text = "0 : " + b;
                
            }

        }

        else
        {
            TimeText.text = "시간끝남";
            return;
        }
    }
}
