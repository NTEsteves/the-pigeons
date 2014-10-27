using UnityEngine;
using System.Collections;

public class ManagerGame : MonoBehaviour 
{
	public GUIStyle customButton;

	public static int score;

	public static int point;  

	//Variavel pra verificar se o game esta pausado
	public static bool isPaused;

	//Variavel pra determinar se o game esta mudo
	public static bool isMute;

	// Metodo para settar os atributos iniciais da cena de Game
	void Start()
	{
		isMute = false;

	}

	//Funçao para convertar as coordenadas
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
