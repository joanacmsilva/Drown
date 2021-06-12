using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegueJogador : MonoBehaviour
{
    public Transform jogador;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, jogador.position.y, 51);
    }
}
