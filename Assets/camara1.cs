using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara1 : MonoBehaviour
{

	public GameObject jugador;
	private Vector3 offset;

	void Start () 
    {	
		//diferencia entre la posición de la cámara y la del jugador
		offset = transform.position - jugador.transform.position;
	}
	
	void LateUpdate () 
    {
		
		//Actualiza la posición de la cámara
		transform.position = jugador.transform.position + offset;

	}
    
}
