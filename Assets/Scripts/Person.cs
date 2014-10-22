using UnityEngine;
using System.Collections;

public class Person : MonoBehaviour {

	int direction;
	Transform trans;

	public float velocity;
	public int[] limitForDestroy = new int[2];

	void Start () 
	{
		trans = GetComponent<Transform>();
	}

	void Update () 
	{
		if(ManagerGame.isPaused) return;

		trans.Translate (new Vector3(velocity *direction, 0, 0));
	
		if(trans.position.x < limitForDestroy[0] || trans.position.x > limitForDestroy[1])
		{
			Destroy(this.gameObject);
		}
	}

	// Metodo para settar a direcao da pessoa (alvo)
	public void setDirection(int d){direction = d;}
}
