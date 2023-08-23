using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buy : MonoBehaviour
{


    public float Price = 100f;
    public MoneyHolder moneyholder;
    public float level = 0;
    public float levelcap = 10;
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;

    
    public void purchase()
    {
        if(moneyholder.CurrentMoney >= Price && levelcap <= level)
        {
            moneyholder.CurrentMoney -= Price;
            level++;
            level1.SetActive(true);

        }
        if(level >=1)
        {
            level2.SetActive(true);
            level1.SetActive(false);
            moneyholder.CurrentMoney -= Price;
            level++;

        }
    }

    
}
