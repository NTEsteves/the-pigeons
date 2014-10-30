using UnityEngine;
using System.Collections;

public class PowerBar : MonoBehaviour 
{
	GUITexture guit;

	void Start () 
	{
		guit = GetComponent<GUITexture>();
	}

	void Update () 
	{
		guit.pixelInset = new Rect (guit.pixelInset.x, guit.pixelInset.y, Pigeon.lastForceBullet * 50, guit.pixelInset.height);
	}


}
