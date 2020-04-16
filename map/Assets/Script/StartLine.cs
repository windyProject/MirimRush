using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLine : MonoBehaviour
{

    public GameObject[] Meteor = new GameObject[6];
    private int ComponentCount = 0;
    private void OnTriggerEnter(Collider other) 
    {
        Invoke("MeteorGravity", 3f);
    }

    private void MeteorGravity()
    {
        ComponentCount++;
        Debug.Log("MeteorGravity()");

        if (ComponentCount == 1)
        {
            for (int i = 0; i < Meteor.Length; i++)
            {
                Meteor[i].AddComponent<Rigidbody>();
                Meteor[i].SetActive(true);
            }
        }
    }
}
