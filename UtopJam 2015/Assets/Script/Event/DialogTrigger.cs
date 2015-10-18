using UnityEngine;
using System.Collections;

public class DialogTrigger : MonoBehaviour {
    public GameObject renderer;
	// Use this for initialization
	void Start () {
        renderer.SetActive(false);
	}

    void Update()
    {
        
    }

    public void ShowSprite(bool b)
    {
        renderer.SetActive(b);
    }
}
