﻿using UnityEngine;
using System.Collections;

public class ManagerGame : MonoBehaviour 
{
	public GUIStyle custom;
	public GUIStyle shadow;

	public static int score;

	public static int point;  

	//Variavel pra verificar se o game esta pausado
	public static bool isPaused;

	//Variavel pra determinar se o game esta mudo
	public static bool isMute;

	public static float dayTime;

	float initialDayTime;

	// Metodo para settar os atributos iniciais da cena de Game
	void Start()
	{
		isMute = false;
		dayTime = 60;

		initialDayTime = dayTime;

		point = 5;

		score = 0;
	}
	void Update()
	{
		if(ManagerGame.isPaused) return;
		dayTime -= Time.deltaTime;
	}

	//Funçao para convertar as coordenadas
	public static Vector3 convertCoordMouse2D(Vector3 mouse3D)
	{
		return Camera.main.ScreenToWorldPoint(mouse3D);
	}

	void OnGUI() 
	{
		//GUI.Label (new Rect (550, 550, 50, 15), "Wind: " + ManagerWild.velocity, custom);
		//GUI.Label (new Rect (550, 230, 50, 15), "Wind Direction: " + ManagerWild.direction, custom);
		//GUI.Label (new Rect (550, 215, 50, 15), "Vel Bullet: " + Pigeon.lastForceBullet, custom);
		GUI.Label (new Rect (Screen.width * 0.2f, Screen.height * 0.95f, 50, 15), "Score: " + score, custom);
		GUI.Label (new Rect (Screen.width * 0.4f, Screen.height * 0.95f, 50, 15), "Point: " + point, custom);  
		GUI.Label (new Rect (Screen.width * 0.6f, Screen.height * 0.95f, 50, 15), "Time: " + dayTime.ToString("F0"), custom);

		//GUI.Label (new Rect (550, 550, 50, 15), "Wind: " + ManagerWild.velocity, shadow);
		//GUI.Label (new Rect (550, 230, 50, 15), "Wind Direction: " + ManagerWild.direction, shadow);
		//GUI.Label (new Rect (550, 215, 50, 15), "Vel Bullet: " + Pigeon.lastForceBullet, shadow);
		GUI.Label (new Rect (Screen.width * 0.2f, Screen.height * 0.95f, 50, 15), "Score: " + score, shadow);
		GUI.Label (new Rect (Screen.width * 0.4f, Screen.height * 0.95f, 50, 15), "Point: " + point, shadow);  
		GUI.Label (new Rect (Screen.width * 0.6f, Screen.height * 0.95f, 50, 15), "Time: " + dayTime.ToString("F0"), shadow);
	}
}
