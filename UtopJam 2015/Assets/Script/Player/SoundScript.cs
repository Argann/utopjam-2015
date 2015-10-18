using UnityEngine;
using System.Collections;

public class SoundScript : MonoBehaviour {

	public AudioSource sound;

	public void PlaySound(){
		sound.Play ();
	}
}
