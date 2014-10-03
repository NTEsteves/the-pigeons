using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public string scene;
	public Sprite mouseOverSprite;
	public Sprite mouseExitSprite;

	public AudioClip clickSound ;

	SpriteRenderer renderer;

	// Use this for initialization
	void Start () 
	{
		renderer = GetComponent<SpriteRenderer>();
		mouseExitSprite = renderer.sprite;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnMouseOver() 
	{
		renderer.sprite = mouseOverSprite;
	}

	void OnMouseExit()
	{
		renderer.sprite = mouseExitSprite;
	}

	void OnMouseDown()
	{
		audio.PlayOneShot(clickSound);

	}

	void OnMouseUp()
	{
		Application.LoadLevel(scene);

	}

}
