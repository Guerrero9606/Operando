using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OcultarYEliminar : MonoBehaviour
{
    public Text contador;
    public GameObject vida;
    public int inicio;

    void Start()
    {
        inicio = 3;
        contador = GameObject.Find("Puntaje").GetComponent<Text>();
        contador.text = "Vidas: " + inicio.ToString();
        /* vida = GameObject.Find("heart");
        Destroy(vida); */
    }

    public void eliminar()
    {
        vida = GameObject.Find("vidas");
        /* Destroy(vida); */
        vida.SetActive(false);
        inicio--;
        contador.text = inicio.ToString();
    }
}
