using UnityEngine;
using System.Collections;

public class InfoVelocityWild : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI()
	{
		guiText.text = "Eu aqui " + ManagerWild.velocity;
	}
}
