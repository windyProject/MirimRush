/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class test2 : MonoBehaviour
{
    SerialPort stream = new SerialPort("COM8", 9600);
    // Start is called before the first frame update
    void Start()
    {
        if (!stream.IsOpen) //포트 연결
            stream.Open();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LedToggle(string data) {
        
        bool LedState = false; //led 꺼졌는지 켜졌는지

        if (LedState == false) //켜졌을때 꺼지게
        {
            stream.Write(data);
            LedState = !LedState;
        }
        else if (LedState) // 꺼졌을때 켜지게
        {
            stream.Write(data.ToLower());
            LedState = !LedState;
        }

    }
    private void OnApplicationQuit()
    {
        stream.Close();//포트 닫기
    }
}
*/