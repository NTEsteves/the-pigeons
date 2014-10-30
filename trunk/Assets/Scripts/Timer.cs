using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour 
{
	public string scene;
	public float dayTime; // Tempo geral

	float initialDayTime; //Tempo inicial

	// Use this for initialization
	void Start () 
	{
		initialDayTime = dayTime; // Tempo inicial é igual ao tempo geral ao ser iniciado.
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(ManagerGame.isPaused) return;

		if (Input.GetKeyDown("f")) {
			Application.LoadLevel(scene);
		}
		dayTime -= Time.deltaTime;

		//Debug.Log("dayTime: " + dayTime);

		if(dayTime <= 0) // Quando o tempo for menor que zero ele irá reiniciar.
		{
			dayTime = initialDayTime;
			Application.LoadLevel(scene);
		}
	
	}
}
