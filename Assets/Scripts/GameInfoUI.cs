using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfoUI : MonoBehaviour
{
    public GameObject GameinfoUI;
    

    private bool isPickedUp = false;


    public void Start()
    {
        GameinfoUI.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("VRController"))
        {
            if (Input.GetButtonDown("VRGrabButton"))
            {
                isPickedUp = true;
                GameinfoUI.SetActive(true);
                GetComponent<Collider>().enabled = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("VRController"))
        {
            // When the controller exits the object's trigger zone, deactivate the info UI and drop the object
            isPickedUp = false;
            GameinfoUI.SetActive(false);
            // Enable the object's collider so it can be interacted with again
            GetComponent<Collider>().enabled = true;
        }
    }
}