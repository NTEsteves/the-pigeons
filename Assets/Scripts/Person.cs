using UnityEngine;
using System.Collections;

public class Person : MonoBehaviour {

	int direction;
	Transform trans;

	public float velocity;

	void Start () {
		trans = GetComponent<Transform>();
	}

	void Update () {
		// Movendo a pessoa
		trans.Translate (new Vector3(velocity *direction, 0, 0));
	}

	// Metodo para settar a direcao da pessoa (alvo)
	public void setDirection(int d){direction = d;}

	void OnCollisionEnter2D(Collision2D other)
	{

	}
}
