using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jogador : MonoBehaviour
{
    [SerializeField]
    GameObject proxNivel;

    [SerializeField]
    GameObject objetoDestruir;

    GameObject pontuacao;

    private void Start()
    {
        pontuacao = GameObject.Find("NumColectaveis");
    }

    private void Update()
    {
        pontuacao.GetComponent<Text>().text = Colectavel.colectaveis.ToString();
        if (Colectavel.colectaveis == 0)
        {
            pontuacao.GetComponent<Text>().text = "Go to the next level!";
            InstanciaProxNivel();
        }
    }
    void InstanciaProxNivel()
    {
        Instantiate(proxNivel);
    }
}
