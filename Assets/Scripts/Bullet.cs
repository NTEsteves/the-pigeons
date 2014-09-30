using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	Rigidbody2D rig2D;
	Transform trans;
	float force;

	// Use this for initialization
	void Start () {

		rig2D = GetComponent<Rigidbody2D>();

		trans = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {

		// Adicionando a velocidade do vendo de acordo com a sua direçao e dividindo pela força gerada pelo
		// pombo
		rig2D.AddForce (new Vector2 ((ManagerWild.velocity *ManagerWild.direction) /force, 0));

		// Caso ele saida da tela pelos lados o objeto tambem sera destruido
		if(trans.position.x < -5 || trans.position.x > 5)
		{
			Destroy(this.gameObject);
		}
	}

	// Metodo gerado para pegar o valor da força em que o tiro vai ser jogado para baixo.
	public void setForce(float f){force = f;}

	// Metodo que determina o momento em que o tiro colide com o chao (Ground)
	void OnCollisionEnter2D(Collision2D other)
	{
		// Determinando a colisao com o GameObject Ground, pela Tag que foi atribuida a ele
		if(other.gameObject.tag == "Ground")
		{
			Destroy(this.gameObject);
		}
	}


}
