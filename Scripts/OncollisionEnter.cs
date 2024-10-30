using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OncollisionEnter : MonoBehaviour

{
    public bool IsJump = false;

    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.CompareTag("Square"))
        {
            IsJump = false;
        }
    }

}
