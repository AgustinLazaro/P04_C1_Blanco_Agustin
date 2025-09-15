using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    private float PlayerSpeed = 5f; 
    private Rigidbody2D rb;
    [SerializeField] private float jumpForce = 7f; 
    [SerializeField] private float fallRotationSpeed = 200f; // Velocidad de rotación al caer
    [SerializeField] private float gravityScale = 2f; // Gravedad personalizada

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = gravityScale; // Aplica la gravedad personalizada
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * PlayerSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        // Si el jeep está cayendo, rota hacia adelante para simular peso
        if (rb.velocity.y < 0)
        {
            transform.Rotate(0, 0, -fallRotationSpeed * Time.deltaTime);
        }
        else if (rb.velocity.y > 0)
        {
            // Opcional: puedes rotar hacia atrás al subir, o dejarlo fijo
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, Time.deltaTime * 5f);
        }
    }
}
