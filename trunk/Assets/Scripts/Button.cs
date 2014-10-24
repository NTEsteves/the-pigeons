using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{
		public string scene;
		public Sprite mouseOverSprite;
		public Sprite mouseExitSprite;
		public AudioClip clickSound ;
		//public float dayTime ;
		//float initialDayTime ; 

		SpriteRenderer renderer;

		// Use this for initialization
		void Start ()
		{
				renderer = GetComponent<SpriteRenderer> ();
				mouseExitSprite = renderer.sprite;
		}
	
		// Update is called once per frame
		void Update ()
		{
	
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

				if (this.gameObject.tag == "btnPause") {
						ManagerGame.isPaused = !ManagerGame.isPaused;
				}

				if (this.gameObject.tag == "btnSound") {
						ManagerGame.isSound = !ManagerGame.isSound;
				}

				if (ManagerGame.isSound) return;

                audio.PlayOneShot (clickSound);
		}

		void OnMouseUp ()
		{
				if (this.gameObject.tag == "btnGeneral") {

						Application.LoadLevel (scene);

				}
		}

}
