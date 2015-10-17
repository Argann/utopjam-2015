using UnityEngine;
using System.Collections;

public class CameraPosition : MonoBehaviour {
    public float distance;
    public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
    void Update(){
        transform.position = new Vector3(target.position.x, target.position.y, target.position.z - distance);
    }
}
