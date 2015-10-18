using System;
using System.Runtime.Remoting;
using UnityEngine;
using System.Collections;

public class SwitchAction : MonoBehaviour
{
    public GameObject[] items;
    public Sprite on;
    public Sprite off;

	private AudioSource sound;

	void Awake(){
		this.GetComponent<SpriteRenderer>().sprite = on;
		sound = GetComponent<AudioSource> ();
	}

    public void SwitchItem()
    {
		sound.Play ();
        if (this.GetComponent<SpriteRenderer> ().sprite == on) {
			this.GetComponent<SpriteRenderer> ().sprite = off;
		} else {
			this.GetComponent<SpriteRenderer> ().sprite = on;
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
