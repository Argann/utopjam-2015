using UnityEngine;
using System.Collections;

public class CameroPositionVertical : MonoBehaviour {
    public float distance;
    public PlayerTrigger target;
    public Transform theTarget;

	// Use this for initialization
	void Start () {
	
	}
	
    void Update(){
        transform.position = new Vector3(-2, theTarget.position.y + 2, theTarget.position.z - distance);
    }
}
