using UnityEngine;
using System.Collections;

public class HiddenPlatform : MonoBehaviour {

	public SpriteRenderer spriterenderer;

	void Awake(){
		spriterenderer.enabled = false;
	}

	public void ShowSprite(bool b){
		spriterenderer.enabled = b;
	}
}
