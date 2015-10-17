using UnityEngine;
using System.Collections;

public class CameraPosition : MonoBehaviour {
    public float distance;
    public PlayerTrigger target;
    public Transform theTarget;
    public float seuil;

	// Use this for initialization
	void Start () {
	
	}
	
    void Update(){
        if (target.ladderState)
        {
            transform.position = new Vector3(theTarget.position.x, theTarget.position.y + 2, theTarget.position.z - distance);
        }
        else
        {
            if (theTarget.position.y < seuil)
                transform.position = new Vector3(theTarget.position.x, 6, theTarget.position.z - distance);
            else
                transform.position = new Vector3(theTarget.position.x, 6+seuil, theTarget.position.z - distance);
        }
    }
}
