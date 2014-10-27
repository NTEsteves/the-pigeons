using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

	public Sprite[] bg = new Sprite[2];
	private AudioSource audioSource;
	private SpriteRenderer sr;

	void Start () {
		audioSource = GetComponent<AudioSource>();
		sr = GetComponent<SpriteRenderer>();
		sr.sprite = bg[Random.Range(0, bg.Length)];
	}
	

	void Update () {
		audioSource.mute = ManagerGame.isMute;
	}
}
