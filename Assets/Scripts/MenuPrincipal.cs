using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    [SerializeField]
    GameObject painelMenu;

    [SerializeField]
    GameObject painelCreditos;

    private void Start()
    {
        painelCreditos.SetActive(false);
        painelMenu.SetActive(true);
    }

    public void CarregaMenu(int nivel)
    {
        PlayerPrefs.SetInt("TotalPontos", 0);
        SceneManager.LoadScene(nivel);
    }


    public void Voltar()
    {
        painelCreditos.SetActive(false);
        painelMenu.SetActive(true);
    }

    public void Creditos()
    {
        painelCreditos.SetActive(true);
        painelMenu.SetActive(false);
    }

    public void Sair()
    {
        Debug.Log("sair");
        Application.Quit();
    }
}
