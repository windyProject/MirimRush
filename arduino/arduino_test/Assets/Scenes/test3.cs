using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEngine.UI;

public class test3 : MonoBehaviour
{
    SerialPort serialP = new SerialPort("COM8", 9600);
    public Text Test_text;

    // Start is called before the first frame update
    void Start()
    {
        if (!serialP.IsOpen) //포트 연결
            serialP.Open();
    }

    // Update is called once per frame
    string tmp = null;
    void Update()
    {

        if (serialP.IsOpen)
        {
            try
            {
                print(serialP.ReadByte());
            }
            catch (System.TimeoutException e)
            {
                Debug.Log(e);
                throw;
            }
            GameObject.Find("Text").GetComponent<Text>().text = "연결됨";
        }
        else if (!serialP.IsOpen) {
            GameObject.Find("Text").GetComponent<Text>().text = "안연결됨";
            serialP.Open();
        }
    }


    public void print(int num) {
        if(num == 1)
            GameObject.Find("Test_text").GetComponent<Text>().text = "10cm 이하";
        else if (num == 2)
            GameObject.Find("Test_text").GetComponent<Text>().text = "10cm 이상";
        else if (num == 0)
            GameObject.Find("Test_text").GetComponent<Text>().text = "측정불가";

    }

    private void OnApplicationQuit()
    {
        serialP.Close();//포트 닫기
    }
}
