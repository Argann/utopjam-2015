using UnityEngine;
using System.Collections;

public class TriggerVaisseau : MonoBehaviour {

	public GameObject vaisseau;

	public void launchAnimation(){
		vaisseau.GetComponent<Animator> ().SetBool ("launchAnimation", true);
	}
}
