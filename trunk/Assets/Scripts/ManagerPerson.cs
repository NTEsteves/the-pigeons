using UnityEngine;
using System.Collections;

public class ManagerPerson : MonoBehaviour {

	// Lista de personagem do jogo que podem ser instanciados
	public GameObject[] person = new GameObject[5];

	private Animator anim; // Atributo para animar

	// Atributo usado para settar o intervalo de criaçao de pessoas (alvos) entre um e outro
	public float[] intervalTimeCreate = new float[2];

	// Atributo que determina o tempo de criaçao entre um e outro de acordo com o sorteio do intervalo do tempo de criaçao
	float timeCreate;

	//Atributo de intervalo entre posiçoes em que a pessoa (alvo) pode ser criado .
	public float[] listPositionCreate = new float[2];
	//Atributo que determina a posiçao de criaçao de acordo com o sortei entre o intervalo
	float positionCreate;
	
	void Start () {
		timeCreate = Random.Range(intervalTimeCreate[0], intervalTimeCreate[1]);
	}

	void Update () {
		timeCreate -= Time.deltaTime;
		if(timeCreate < 0)
		{
			createPerson();
		}
	}

	void createPerson()
	{
		// Esta linha define em qual lado os personagem irão nascer, se é na esquerda ou na direita
		positionCreate = Random.Range(0, 3) %2 == 0 ? listPositionCreate[0] : listPositionCreate[1]; //IF

		// A linha que instancia o meu prefab de um personagem
		GameObject go = Instantiate(person[Random.Range(0, person.Length -1)], new Vector3(positionCreate, -2f, 0), Quaternion.identity) as GameObject;

		// Setando o tempo de criação do personagem que esta sendo sorteado
		timeCreate = Random.Range(intervalTimeCreate[0], intervalTimeCreate[1]);

		// Condicao que verifica onde ele ira nascer e da a determinada direcao
		if(positionCreate <= -5)
		{
			go.GetComponent<Person>().setDirection(1); // Da esquerda pra direita

		}else
		{
			go.GetComponent<Person>().setDirection(-1); // Da direita pra esquerda
		}
	}
}
