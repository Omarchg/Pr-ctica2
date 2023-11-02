using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject PantallaDerrota;
    public float speed = 10f;
    public Rigidbody rb;
    private bool canJump = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        
        transform.Translate(horizontal, 0, vertical);


        if(Input.GetButtonDown("Jump") && canJump)
        {
            rb.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
            canJump = false;
        }

        
    }

   
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            canJump = true; // Player can jump again when grounded
        }
        if (collision.gameObject.CompareTag("SueloDerrota"))
        {
            PantallaDerrota.SetActive(true);
            Time.timeScale = 0;
        }

    }
}
