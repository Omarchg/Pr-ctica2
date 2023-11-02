using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public Transform player; // Referencia al jugador.
    public Transform staticPosition; // Posición de la cámara en modo plano general.
    public Transform thirdPersonPosition; // Posición de la cámara en modo tercera persona.
    public float transitionSpeed = 5.0f; // Velocidad de transición suave.

    private bool isThirdPerson = true; // Indica si la cámara está en modo tercera persona.

    private void Start()
    {
        // Inicialmente, la cámara estará en modo tercera persona.
        transform.position = thirdPersonPosition.position;
    }

    private void Update()
    {
        // Detecta la entrada del jugador para cambiar entre los modos de cámara.
        if (Input.GetKeyDown(KeyCode.C))
        {
            isThirdPerson = !isThirdPerson; // Cambia entre los modos.
        }
        
        // Mueve la cámara hacia la posición correspondiente.
        if (isThirdPerson)
        {
            MoveTowardsCameraPosition(thirdPersonPosition);
            
        }
        else
        {
            MoveTowardsCameraPosition(staticPosition);
            
        }
		
    }

    private void MoveTowardsCameraPosition(Transform target)
    {
        // Mueve la cámara suavemente hacia la nueva posición.
        transform.position = Vector3.MoveTowards(transform.position, target.position, transitionSpeed * Time.deltaTime);
    }


}