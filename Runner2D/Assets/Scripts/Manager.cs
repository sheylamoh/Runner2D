using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    private int puntuacion = 0;
    public Text textoPuntos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementarPuntos(int pts)
    {
        puntuacion += pts;
        Debug.Log("Puntuacion: " + puntuacion);
        textoPuntos.text = "Score: " + puntuacion.ToString();
    }
}
