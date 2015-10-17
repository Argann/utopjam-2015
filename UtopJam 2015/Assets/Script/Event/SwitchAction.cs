using System;
using System.Runtime.Remoting;
using UnityEngine;
using System.Collections;

public class SwitchAction : MonoBehaviour
{
    public GameObject[] items;

    public void SwitchItem()
    {
        foreach (GameObject item in items)
        {
            if (item.GetComponent<Element>().GetIsActive())
            {
                item.GetComponent<Element>().Desactivate();
                Debug.Log(item + "is stopped");
            }
            else
            {
                item.GetComponent<Element>().Activate();
            } 
        }
    }
}
