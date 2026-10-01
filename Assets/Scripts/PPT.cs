using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPT : MonoBehaviour
{
    public string[] jugada = {"piedra", "papel", "tijera"};

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            CheckResult("piedra");
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            CheckResult("papel");
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            CheckResult("tijera");
        }
    }

    void CheckResult(string jugador)
    {
        string jugadaContrincante = jugada[Random.Range(0, 3)];

        Debug.Log("Jugaste " + jugador + ", y tu contrincante " +jugadaContrincante);

        if (jugador == jugadaContrincante)
        {
            Debug.Log("Empate");
        }
        else if (jugador == "piedra" && jugadaContrincante == "tijera"
        ||jugador == "papel" && jugadaContrincante == "piedra"
        ||jugador == "tijera" && jugadaContrincante == "papel")
        {
            Debug.Log("Ganaste");
        }
        else
        {
            Debug.Log("Perdiste");
        }
    }
}