using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	Rigidbody2D rig2D;
	Transform trans;
	float force;
	public AudioClip clickSound;

	public int[] limitForDestroy = new int[2];

	// Use this for initialization
	void Start () {

		rig2D = GetComponent<Rigidbody2D>();
		trans = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {

		// Adicionando a velocidade do vendo de acordo com a sua direçao e dividindo pela força gerada pelo
		// pombo
		rig2D.AddForce (new Vector2 ((ManagerWind.velocity *ManagerWind.direction) /force, 0));

		// Caso ele saida da tela pelos lados o objeto tambem sera destruido
		if(trans.position.x < limitForDestroy[0] || trans.position.x > limitForDestroy[1])
		{
			Destroy(this.gameObject);
		}
	}

	// Metodo gerado para pegar o valor da força em que o tiro vai ser jogado para baixo.
	public void setForce(float f){force = f;}

	// Metodo que determina o momento em que o tiro colide com o chao (Ground)
	void OnTriggerEnter2D(Collider2D other)
	{
		// Determinando a colisao com o GameObject , pela Tag que foi atribuida a ele
		switch(other.gameObject.tag)
		{
		case "Ground":
			Destroy(this.gameObject);
			break;

		case "Person":

			//audio.PlayOneShot(clickSound);
			ManagerGame.score ++;
			ManagerGame.point ++;
			Destroy(this.gameObject);

			break;
				
		}
	
	}

}
