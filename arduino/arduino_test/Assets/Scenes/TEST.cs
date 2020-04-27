using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class TEST : MonoBehaviour
{
    public enum PortNumber
    { 
        COM1, COM2, COM3, COM4,
        COM5, COM6, COM7, COM8,
        COM9, COM10, COM11, COM12,
        COM13, COM14, COM15, COM16
    }

    //연결된 포트 , BAUD RATE(통신속도)
    private SerialPort serial;

    [SerializeField]
    private PortNumber portNumber = PortNumber.COM8;
    [SerializeField]
    private string baudRate = "9600";

    private bool Orgstate = false;

    // Start is called before the first frame update
    void Start()
    {
        serial = new SerialPort(portNumber.ToString(), int.Parse(baudRate));
    }

    public void LedToggle(string data)
    {
        bool LedState = false;

        switch (data) {
            case "O":
                LedState = Orgstate;
                break;
        }
        //포트연결
        if(! serial.IsOpen)
        serial.Open();

        //점등
        if (LedState == false)
        {
            serial.Write(data);
            LedState = !LedState;
        }
        else if (LedState)
        {
            serial.Write(data.ToLower());
            LedState = !LedState;
        }

        switch (data) {
            case "O":
                LedState = LedState;
                break;
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
