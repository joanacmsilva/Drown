using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inimigo : MonoBehaviour
{

    [SerializeField]
    float temporizador = 20;

    [SerializeField]
    Text mostrador;

    private bool contaTempo = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ContadorTemporal();
    }
    void ContadorTemporal()
    {
        if (contaTempo)
        {
            MostraTempo(temporizador);
            if (temporizador > 0)
            {
                temporizador -= Time.deltaTime;
            }
            else
            {
                temporizador = 0;
                contaTempo = false;
            }
        }
    }
    void MostraTempo(float relogio)
    {
        float minutos = Mathf.FloorToInt(relogio / 60);
        float segundos = Mathf.FloorToInt(relogio % 60);

        mostrador.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }
}
