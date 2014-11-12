using UnityEngine;
using System.Collections;

public class ManagerPerson : MonoBehaviour {

	//Atributo que sera usado para referenciar qual prefab nos queremos instanciar
	public GameObject person;

	public Animator[] an = new Animator[5];
	

	private Animator anim; // Atributo para animar

	// Atributo usado para settar o intervalo de criaçao de pessoas (alvos) entre um e outro
	public float[] intervalTimeCreate = new float[2];
	// Atributo que determina o tempo de criaçao entre um e outro de acordo com o sorteio do intervalo do tempo de criaçao
	float timeCreate;

	//Atributo de intervalo entre posiçoes em que a pessoa (alvo) pode ser criado .
	public float[] intervalPositionCreate = new float[2];
	//Atributo que determina a posiçao de criaçao de acordo com o sortei entre o intervalo
	float positionCreate;
	
	void Start () {
		timeCreate = Random.Range(intervalTimeCreate[0], intervalTimeCreate[1]);
		anim.Animator = an[Random.Range(0, an.Length)];
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
		positionCreate = Random.Range(0, 3) %2 == 0 ? intervalPositionCreate[0] : intervalPositionCreate[1];
		GameObject go = Instantiate(person, new Vector3(positionCreate, -2f, 0), Quaternion.identity) as GameObject;
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
