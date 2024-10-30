using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D RB;
    public float speed;
    public float JumpForce;

    public PuntuacionTotalJuego SistemaDePuntuacion;

    public float CloneAxis;
    public bool IsJump = false;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();

        GameObject OBJ = GameObject.Find("GameManager");
        SistemaDePuntuacion = OBJ.GetComponent<PuntuacionTotalJuego>();

    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        RB.velocity = new Vector2(moveInput * speed, RB.velocity.y);

        CloneAxis = moveInput;

        if (moveInput < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (moveInput > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        Jump();
    }

    public void Jump()
    {
        if (Input.GetButtonDown("Jump") && !IsJump)
        {
            RB.AddForce(new Vector3(0, JumpForce * 10, 0));
            IsJump = true;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            IsJump = false;
        }
    }

    private int value;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Punto"))
        {
            SistemaDePuntuacion.puntuacionTotal(3);
            Destroy(collision.gameObject);
        }

    }

}
