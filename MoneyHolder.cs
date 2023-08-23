using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyHolder : MonoBehaviour
{
    public float CurrentMoney = 0f;
    public GameObject buymenu;
    public TextMeshProUGUI MoneyCount;

    // Update is called once per frame

        void Update()
    {
        MoneyCount.SetText(CurrentMoney.ToString());
        
        if(Input.GetKeyDown(KeyCode.Q))
        {
            buymenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = .3f;
            Cursor.visible = true;
        }
        if(Input.GetKeyUp(KeyCode.Q))
        {
            Cursor.lockState = CursorLockMode.Locked;
            buymenu.SetActive(false);
            Time.timeScale = 1f;
            Cursor.visible = false;
        }
        if(Input.GetKeyDown(KeyCode.RightControl))
        {
            buymenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = .3f;
            Cursor.visible = true;
        }
        if(Input.GetKeyUp(KeyCode.RightControl))
        {
            Cursor.lockState = CursorLockMode.Locked;
            buymenu.SetActive(false);
            Time.timeScale = 1f;
            Cursor.visible = false;
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            buymenu.SetActive(false);
        }
    }
}
