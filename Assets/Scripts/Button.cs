using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{
	public string scene;
	public Sprite mouseOverSprite;
	public Sprite mouseExitSprite;
	public AudioClip clickSound ;
		 
	private SpriteRenderer renderer;
	private AudioSource audioSource;

	void Start ()
	{
		renderer = GetComponent<SpriteRenderer> ();
		audioSource = GetComponent<AudioSource>();
		mouseExitSprite = renderer.sprite;
	}

	void Update ()
	{
		audioSource.mute = ManagerGame.isMute;
	}

	void OnMouseOver ()
	{
		renderer.sprite = mouseOverSprite;
	}

	void OnMouseExit ()
	{
		renderer.sprite = mouseExitSprite;
	}

	void OnMouseDown ()
	{

		if (this.gameObject.tag == "btnPause") 
		{
			ManagerGame.isPaused = !ManagerGame.isPaused;
		}

		if (this.gameObject.tag == "btnSound") 
		{
			ManagerGame.isMute = !ManagerGame.isMute;
		}

		audio.PlayOneShot (clickSound);
	}

	void OnMouseUp ()
	{
		if (this.gameObject.tag == "btnGeneral") 
		{

			Application.LoadLevel (scene);

		}
	}

}
