using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  //IMPORTANTE Asginar la libreria Text Mesh Pro





public class PuntuacionTotalJuego : MonoBehaviour

    
{
    private int Puntos;
    public TextMeshProUGUI TextUI;
    public ControlDeEscenas escenas;


    // Start is called before the first frame update
    void Start()
    {
        escenas = GetComponent<ControlDeEscenas>();
    }

    // Update is called once per frame
    void Update()
    {
        TextUI.text = Puntos.ToString();

        if(Puntos >= 1)
        {
            escenas.EscenaWin();
        }
    }


    public void puntuacionTotal(int value)
    {
        Puntos = Puntos + value;
    }
}
