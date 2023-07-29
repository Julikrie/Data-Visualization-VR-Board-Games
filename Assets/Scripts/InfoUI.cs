using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoUI : MonoBehaviour
{
    

   
    void Start()
    {
        gameObject.SetActive(false); 
    }

    public void ShowInfoUI()
    {
        if(!gameObject.activeSelf)
        {
            gameObject.SetActive(true);
        }
    }
    
}
