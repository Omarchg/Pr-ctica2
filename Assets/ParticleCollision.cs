using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParticleCollision : MonoBehaviour
{
    [SerializeField]
    GameObject PantallaVictoria;

    [SerializeField]
    TextMeshProUGUI textTime;

    int monedas = 0;
    public ParticleSystem particulasMoneda;
    float tiempodepartida = 0.0f;
    void Start()
    {
        particulasMoneda.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempodepartida = tiempodepartida + Time.deltaTime;
        if(monedas>=3) 
        {
            textTime.text = tiempodepartida.ToString();
            PantallaVictoria.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Moneda"))
        {
            particulasMoneda.gameObject.SetActive(true);
            particulasMoneda.transform.position = other.transform.position;
            particulasMoneda.Play();

            other.gameObject.SetActive(false);
            monedas++;
        }
    }
}
