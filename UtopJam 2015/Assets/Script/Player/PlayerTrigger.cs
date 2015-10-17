using UnityEngine;
using System.Collections;

public class PlayerTrigger : MonoBehaviour {

	private bool touchingLightSwitch = false;
	private GameObject lightSwitch = null;
	private bool touchingLadder = false;
	private GameObject ladder = null;

	void OnTriggerEnter2D(Collider2D other_go){
		Debug.Log ("On entre !");
		if (other_go.tag == "LightSwitch") {
			touchingLightSwitch = true;
			lightSwitch = other_go.gameObject;
		} else if (other_go.tag == "Ladder") {
			touchingLadder = true;
			ladder = other_go.gameObject;
		}
	}

	void OnTriggerExit2D(Collider2D other_go){
		Debug.Log ("On sort !");
		if (other_go.tag == "LightSwitch") {
			touchingLightSwitch = false;
			lightSwitch = null;
		} else if (other_go.tag == "Ladder") {
			touchingLadder = false;
			ladder = null;
		}
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.E)) {
			if (touchingLightSwitch)
				lightSwitch.GetComponent<SwitchAction>().SwitchItem();
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			if (touchingLadder)
				Debug.Log ("On grimpe : " + ladder);
		}
	}
}
