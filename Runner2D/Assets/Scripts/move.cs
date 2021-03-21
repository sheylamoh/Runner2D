using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class move : MonoBehaviour
{
    public float Speed;
    public float JumpForce;

    private Rigidbody2D Rigidbody2D;
    private Animator Animator;
    private float Horizontal;

    public Manager gameManager;

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
        gameManager = FindObjectOfType<Manager>();
    }

    void Update()
    {
        Rigidbody2D.velocity = new Vector2(Speed, Rigidbody2D.velocity.y);

        
        Animator.SetBool("running", Horizontal != 0.0f);

        

        if (Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
    }

    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
    }

    /*private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal * Speed, Rigidbody2D.velocity.y);
    }*/

    // se llama cuando player colisiona con cualquier objeto con la propiedad collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("monedaOro"))
        {
            Debug.Log("+ 10 puntos");
            Destroy(collision.gameObject);
            gameManager.IncrementarPuntos(10);
        }
        else if(collision.gameObject.CompareTag("monedaBronce"))
        {
            Debug.Log("+ 5 puntos");
            Destroy(collision.gameObject);
            gameManager.IncrementarPuntos(5);
        }
        else if (collision.gameObject.CompareTag("zonaMuerte"))
        {
            Debug.Log("Game over");
            PlayerDead();
        }
    }

    private void PlayerDead()
    {
        // carga una escena nueva o reinicia - pantalla principal del juego
        SceneManager.LoadScene("level2d");
        
    }

}