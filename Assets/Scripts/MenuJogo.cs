using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuJogo : MonoBehaviour
{

    [SerializeField]
    GameObject painelPausa;

    public static bool JogoEmPausa = false;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (JogoEmPausa)
            {
                VoltarJogo();
            }
            else
            {
                PausaJogo();
            }
        }
    }

    public void VoltarJogo()
    {
        JogoEmPausa = false;
        painelPausa.SetActive(false);
        Time.timeScale = 1f;
    }

    void PausaJogo()
    {
        JogoEmPausa = true;
        painelPausa.SetActive(true);
        Time.timeScale = 0f;

    }

    public void CarregaMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void Sair()
    {
        Debug.Log("sair");
        Application.Quit();
    }
}
