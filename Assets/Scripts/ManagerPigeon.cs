using UnityEngine;
using System.Collections;

public class ManagerPigeon : MonoBehaviour {

	public GameObject pigeon;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(ManagerGame.point >= 5 )
		{
			ManagerGame.point -= 5;
		}
	}

	void OnMouseDown()
	{
		GameObject go = Instantiate (pigeon, new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0), Quaternion.identity) as GameObject;
	}
}
