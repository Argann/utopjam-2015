using UnityEngine;
using System.Collections;

public class TeleportTrigger : MonoBehaviour {

	private FadeInFadeOut fade;

	void Awake(){
		fade = gameObject.GetComponent<FadeInFadeOut> ();
	}

	void OnTriggerEnter2D(){
		fade.fadeOut = true;
	}
}
