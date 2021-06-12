using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colectavel : MonoBehaviour
{
    public static int colectaveis = 0;

    private void Awake()
    {
        colectaveis++;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(45, 30, 15));
    }

    private void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
            colectaveis--;
        gameObject.SetActive(false);
    }

}