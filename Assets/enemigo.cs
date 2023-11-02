using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    [SerializeField]
    GameObject PantallaDerrota;
    public float speed;
    public Transform objetivo;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, objetivo.position, speed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, 1.479718f, transform.position.z);
        transform.LookAt(objetivo);

    }

    private void OnTriggerEnter(Collider enemigo)
    {
        if (enemigo.CompareTag("Player"))
        {
            PantallaDerrota.SetActive(true);
            Time.timeScale = 0;
        }
    }    


}
