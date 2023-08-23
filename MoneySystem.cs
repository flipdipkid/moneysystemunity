using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class moneysystem : MonoBehaviour
{
    public MoneyHolder moneyholder;
    public float reward = 1000f;
    public GameObject thisObject;

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            moneyholder.CurrentMoney += reward;
        }
        Destroy(thisObject);
    }
    
}
