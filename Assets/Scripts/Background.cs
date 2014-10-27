using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

	private AudioSource audioSource;

	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	

	void Update () {
		audioSource.mute = ManagerGame.isMute;
	}
}
