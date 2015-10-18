using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class PlayerTrigger : MonoBehaviour {

	private bool touchingLightSwitch = false;
	private GameObject lightSwitch = null;

	private bool touchingLadder = false;
	public bool ladderState = false;
	private GameObject ladder = null;

	private bool touchingVaisseau = false;
	private GameObject vaisseau;

	void OnTriggerEnter2D(Collider2D other_go){
        
		if (other_go.tag == "LightSwitch") {
			touchingLightSwitch = true;
			lightSwitch = other_go.gameObject;
		} else if (other_go.tag == "Ladder") {
			touchingLadder = true;
			ladder = other_go.gameObject;
		} else if (other_go.tag == "HiddenPlatform") {
			other_go.gameObject.GetComponent<HiddenPlatform> ().ShowSprite (true);
		} else if (other_go.tag == "Door") {
			other_go.GetComponent<Animator> ().SetBool ("doorIsOpen", true);
		} else if (other_go.tag == "TriggerDoor") {
			other_go.GetComponent<FadeInFadeOut> ().fadeOut = true;
		} else if (other_go.tag == "TriggerVaisseau") {
			touchingVaisseau = true;
			vaisseau = other_go.gameObject;
        } else if (other_go.tag == "HidingElement") {
            other_go.gameObject.GetComponent<DisappearingElement>().ShowSprite(true);
        }  else if (other_go.tag == "Dialogue")
        {
            Debug.Log("test");
            other_go.gameObject.GetComponent<DialogTrigger>().ShowSprite(true);
        }

	}

	void OnTriggerExit2D(Collider2D other_go){
		if (other_go.tag == "LightSwitch") {
			touchingLightSwitch = false;
			lightSwitch = null;
		} else if (other_go.tag == "Ladder") {
			touchingLadder = false;
			ladderState = false;
			GetComponent<Rigidbody2D>().gravityScale = 3;
			ladder = null;
			gameObject.GetComponent<Animator>().SetBool("Grimpe", false);
		} else if (other_go.tag == "HiddenPlatform") {
			other_go.gameObject.GetComponent<HiddenPlatform>().ShowSprite(false);
        } else if (other_go.tag == "HidingElement")
        {
            other_go.gameObject.GetComponent<DisappearingElement>().ShowSprite(false);
		} else if (other_go.tag == "TriggerVaisseau") {
			touchingVaisseau = false;
			vaisseau = null;
		}
        else if (other_go.tag == "Dialogue")
        {
            other_go.gameObject.GetComponent<DialogTrigger>().ShowSprite(false);
        }
	}

	void Update(){

		if (Input.GetKeyDown (KeyCode.E)) {
			if (touchingLightSwitch)
				lightSwitch.GetComponent<SwitchAction>().SwitchItem();

			if (touchingVaisseau)
				vaisseau.GetComponent<TriggerVaisseau>().launchAnimation();

		}

		if (ladderState) {
			gameObject.GetComponent<Animator>().SetBool("Grimpe", true);
		}

		if (ladderState && !Input.GetKey (KeyCode.UpArrow) && !Input.GetKey (KeyCode.DownArrow)) {
			gameObject.GetComponent<Animator>().SetBool("BougeGrimpe", false);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			if (touchingLadder && !ladderState){
				ladderState = true;
				GetComponent<Rigidbody2D>().gravityScale = 0f;
				GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
			} else if (touchingLadder && ladderState && (ladder.transform.position.y >= transform.position.y)){
				transform.position += new Vector3(0f, 0.1f);
			}
			gameObject.GetComponent<Animator>().SetBool("BougeGrimpe", true);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			if (touchingLadder && !ladderState){
				ladderState = true;
				GetComponent<Rigidbody2D>().gravityScale = 0f;
			} else if (touchingLadder && ladderState && !GetComponent<PlatformerCharacter2D>().m_Grounded){
				transform.position += new Vector3(0f, -0.1f);
			}
			gameObject.GetComponent<Animator>().SetBool("BougeGrimpe", true);
		}

		if (Input.GetKeyDown (KeyCode.Space) && ladderState) {
			ladderState = false;
			GetComponent<Rigidbody2D>().gravityScale = 3;
		}
	}
}
