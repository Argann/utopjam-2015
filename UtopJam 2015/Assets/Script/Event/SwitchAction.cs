using System;
using System.Runtime.Remoting;
using UnityEngine;
using System.Collections;

public class SwitchAction : MonoBehaviour
{
    public GameObject[] items;
    public Sprite on;
    public Sprite off;

    public void SwitchItem()
    {
        if (this.GetComponent<SpriteRenderer>().sprite == on)
        {
            this.GetComponent<SpriteRenderer>().sprite = off;
        }
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
