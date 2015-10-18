using UnityEngine;
using System.Collections;

public class DoorTeleport : MonoBehaviour {

	public GameObject fade;

	void teleport(){
		fade.GetComponent<FadeInFadeOut> ().EndScene ();
	}

}
