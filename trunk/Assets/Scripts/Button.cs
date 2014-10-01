using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public string Scene;
	public Sprite mouseOverSprite;
	public Sprite mouseExitSprite;

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

		Application.LoadLevel(Scene);
	}

}
