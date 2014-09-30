using UnityEngine;
using System.Collections;

public class ManagerPerson : MonoBehaviour {

	//Atributo que sera usado para referenciar qual prefab nos queremos instanciar
	public GameObject person;

	// Atributo usado para settar o intervalo de criaçao de pessoas (alvos) entre um e outro
	public float[] intervalCreate = new float[2];
	float timeCreate;

	public float[] intervalPositionCreate = new float[2];
	float positionCreate;

	// Use this for initialization
	void Start () {
		timeCreate = Random.Range(intervalCreate[0], intervalCreate[1]);
	}
	
	// Update is called once per frame
	void Update () {
		timeCreate -= Time.deltaTime;
		if(timeCreate < 0)
		{
			positionCreate = Random.Range(0, 3) %2 == 0 ? intervalPositionCreate[0] : intervalPositionCreate[1];
			GameObject go = Instantiate(person, new Vector3(positionCreate, -2.2f, 0), Quaternion.identity) as GameObject;
			timeCreate = Random.Range(intervalCreate[0], intervalCreate[1]);
		}
	}
}
