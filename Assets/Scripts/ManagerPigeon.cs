using UnityEngine;
using System.Collections;

public class ManagerPigeon : MonoBehaviour {

	public GameObject pigeon;
	public AudioClip clickSound ;

	Vector3 mouse2D;

	// Use this for initialization
	void Start () {
		ManagerGame.point = 5;

	}
	

	// Update is called once per frame
	void Update () {

		// Foi criada um metodo estatico no script ManagerGame para converter as coordenadas do mouse de 3D para 2D
		mouse2D = ManagerGame.convertCoordMouse2D (new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));


	}

	void OnMouseDown()
	{
		if(ManagerGame.isPaused) return;

		audio.PlayOneShot(clickSound);

		//if(ManagerGame.point >= 5 )
		//{
			GameObject go = Instantiate (pigeon, new Vector3(mouse2D.x, mouse2D.y, 0), Quaternion.identity) as GameObject;
			ManagerGame.point -= 5;
		//}
	}
}