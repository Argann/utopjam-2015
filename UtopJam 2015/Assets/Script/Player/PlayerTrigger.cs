using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class PlayerTrigger : MonoBehaviour {

	private bool touchingLightSwitch = false;
	private GameObject lightSwitch = null;

	private bool touchingLadder = false;
	private bool ladderState = false;
	private GameObject ladder = null;

	void OnTriggerEnter2D(Collider2D other_go){
		Debug.Log ("On entre !");
		if (other_go.tag == "LightSwitch") {
			touchingLightSwitch = true;
			lightSwitch = other_go.gameObject;
		} else if (other_go.tag == "Ladder") {
			touchingLadder = true;
			ladder = other_go.gameObject;
		} else if (other_go.tag == "HiddenPlatform") {
			other_go.gameObject.GetComponent<HiddenPlatform>().ShowSprite(true);
		}
	}

	void OnTriggerExit2D(Collider2D other_go){
		Debug.Log ("On sort !");
		if (other_go.tag == "LightSwitch") {
			touchingLightSwitch = false;
			lightSwitch = null;
		} else if (other_go.tag == "Ladder") {
			touchingLadder = false;
			ladderState = false;
			GetComponent<Rigidbody2D>().gravityScale = 3;
			ladder = null;
		} else if (other_go.tag == "HiddenPlatform") {
			other_go.gameObject.GetComponent<HiddenPlatform>().ShowSprite(false);
		}
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.E)) {
			if (touchingLightSwitch)
				lightSwitch.GetComponent<SwitchAction>().SwitchItem();
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			if (touchingLadder && !ladderState){
				ladderState = true;
				GetComponent<Rigidbody2D>().gravityScale = 0f;
				GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
			} else if (touchingLadder && ladderState && (ladder.transform.position.y >= transform.position.y)){
				transform.position += new Vector3(0f, 0.1f);
			}
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			if (touchingLadder && !ladderState){
				ladderState = true;
				GetComponent<Rigidbody2D>().gravityScale = 0f;
			} else if (touchingLadder && ladderState && !GetComponent<PlatformerCharacter2D>().m_Grounded){
				transform.position += new Vector3(0f, -0.1f);
			}
		}

		if (Input.GetKeyDown (KeyCode.Space) && ladderState) {
			ladderState = false;
			GetComponent<Rigidbody2D>().gravityScale = 3;
		}
	}

    public bool OnLadder()
    {
        return ladderState;
    }
}
