using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip coleccionableSound;
    private AudioSource AudioSource;
    
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Moneda"))
        {
            PlayColeccionableSound();
        }
    }

    private void PlayColeccionableSound()
    {
        if (coleccionableSound != null)
        {
            AudioSource.PlayOneShot(coleccionableSound);
        }
    }
    
}
