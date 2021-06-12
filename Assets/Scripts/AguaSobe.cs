using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AguaSobe : MonoBehaviour
{
    public Transform target;
    public float t;
    public float speed;

    [SerializeField]
    GameObject painelMorte;

    public static bool JogoEmPausa = false;

    float spawn;

    // Start is called before the first frame update
    void Start()
    {
        spawn = Time.time + 20.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawn)
        {
            SobeAgua();
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("rip");
            PausaJogo();
        }
    }
 
    void SobeAgua()
    {
        Vector3 a = transform.position;
        Vector3 b = target.position;
        transform.position = Vector3.MoveTowards(a, Vector3.Lerp(a, b, t), speed);
    }

    void PausaJogo()
    {
        JogoEmPausa = true;
        painelMorte.SetActive(true);
        Time.timeScale = 0f;

    }
    public void CarregaMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void Retry1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void Retry2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
    }
    public void Retry3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(3);
    }
    public void Retry4()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(4);
    }
}
