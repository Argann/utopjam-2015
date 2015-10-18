using UnityEngine;
using System.Collections;

public class OneWayPlatform : MonoBehaviour {

    public BoxCollider2D platform;
    public bool oneWay = false;

    void Start()
    {
    }

    void Update()
    {
        platform.enabled = !oneWay;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        oneWay = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        oneWay = false;
    }
}
