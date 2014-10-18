using UnityEngine;
using System.Collections;

public class ManagerGame : MonoBehaviour {

	public GUIStyle customButton;
	public static int score;
	public static int point;

	public static bool isPaused;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	public static Vector3 convertCoordMouse2D(Vector3 mouse3D)
	{
		return Camera.main.ScreenToWorldPoint(mouse3D);
	}

	void OnGUI() 
	{
		GUI.Label (new Rect (40, 200, 50, 15), "Wild: " + ManagerWild.velocity, customButton);
		GUI.Label (new Rect (40, 230, 50, 15), "Wild Direction: " + ManagerWild.direction, customButton);
		GUI.Label (new Rect (40, 215, 50, 15), "Vel Bullet: " + Pigeon.lastForceBullet, customButton);
		GUI.Label (new Rect (40, 245, 50, 15), "Score: " + score, customButton);
		GUI.Label (new Rect (40, 260, 50, 15), "Point: " + point, customButton);
		GUI.Label (new Rect (40, 310, 50, 15), "Is Pause: " + isPaused, customButton);
	}
}
