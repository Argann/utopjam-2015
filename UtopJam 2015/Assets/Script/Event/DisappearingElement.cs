using UnityEngine;
using System.Collections;

public class DisappearingElement : MonoBehaviour {

	public SpriteRenderer spriterenderer;

	void Awake(){
		spriterenderer.enabled = true;
	}

	public void ShowSprite(bool b){
		spriterenderer.enabled = !b;
	}
}
