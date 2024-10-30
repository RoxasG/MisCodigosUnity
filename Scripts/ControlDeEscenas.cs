using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlDeEscenas : MonoBehaviour
{
    public void EscenaJuego()
    {
        SceneManager.LoadScene("EscenaJuego");
    }

    public void EscenaWin()
    {
        SceneManager.LoadScene("EscenaWin");
    }
}
