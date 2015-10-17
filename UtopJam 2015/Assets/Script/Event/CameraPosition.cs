using UnityEngine;
using System.Collections;

public class CameraPosition : MonoBehaviour {
    public float distance;
    public GameObject target;

	// Use this for initialization
	void Start () {
	
	}
	
    void Update(){
        if (target.GetComponent<PlayerTrigger>().OnLadder())
        {
            transform.position = new Vector3(target.transform.position.x, target.transform.position.y +2, target.transform.position.z - distance);
        }
        else
        {
            transform.position = new Vector3(target.transform.position.x, 6, target.transform.position.z - distance);
        }
    }
}
