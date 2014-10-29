using UnityEngine;
using System.Collections;

public class PowerBar : MonoBehaviour {

	public static bool dayTime;

	bool initialDayTime;
	
	GUITexture guit;

	void Start () {
		guit = GetComponent<GUITexture>();
	}

	void Update () {
		guit.pixelInset = new Rect (guit.pixelInset.x, guit.pixelInset.y, Pigeon.lastForceBullet *50, guit.pixelInset.height);
	
		if( dayTime = initialDayTime)
		{
		
			guit.pixelInset = new Rect (guit.pixelInset.x, guit.pixelInset.y, Pigeon.lastForceBullet *50, guit.pixelInset.height);
		}	
	}


}
