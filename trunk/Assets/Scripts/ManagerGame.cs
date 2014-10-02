using UnityEngine;
using System.Collections;

public class ManagerGame : MonoBehaviour {

	public GUIStyle customButton;
	public GameObject player;
	int points;
	float time;
	int life;
	public static int score;
	public static int point;

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI() 
	{
		GUI.Label (new Rect (40, 200, 50, 15), "Wild: " + ManagerWild.velocity, customButton);
		GUI.Label (new Rect (40, 230, 50, 15), "Wild Direction: " + ManagerWild.direction, customButton);
		GUI.Label (new Rect (40, 215, 50, 15), "Vel Bullet: " + Pigeon.forceBullet, customButton);
		GUI.Label (new Rect (40, 245, 50, 15), "Score: " + score, customButton);
		GUI.Label (new Rect (40, 245, 50, 15), "Point: " + point, customButton);
	}
}
