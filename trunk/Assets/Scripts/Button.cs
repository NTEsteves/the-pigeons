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
	
	void OnMouseDown ()
	{

		if (this.gameObject.tag == "btnPause") 
		{
			ManagerGame.isPaused = !ManagerGame.isPaused;
			renderer.sprite = ManagerGame.isPaused ? mouseOverSprite : mouseExitSprite;
		}

		if (this.gameObject.tag == "btnSound") 
		{
			GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().volume = (GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().volume == 0)?1:0;

			ManagerGame.isMute = !ManagerGame.isMute;
			renderer.sprite = ManagerGame.isMute ? mouseOverSprite : mouseExitSprite;
		}

		audio.PlayOneShot (clickSound);
	}

	void OnMouseUp ()
	{

		if (this.gameObject.tag == "btnGeneral") 
		{
			Application.LoadLevel (scene);
			Pigeon.lastForceBullet = 0;

		}
	}

}
