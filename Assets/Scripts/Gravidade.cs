using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class Gravidade : MonoBehaviour
{
    public bool gravitySwitch;
    ThirdPersonCharacter controlaJogador;

    private float rodar = 0f;
    private int roda = 0;

    // Start is called before the first frame update
    void Start()
    {
        controlaJogador = GetComponent<ThirdPersonCharacter>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gravitySwitch = !gravitySwitch;

            if (gravitySwitch)
            {
  
                Physics.gravity = new Vector3(0, 9.81f, 0);
                roda = 1;
                controlaJogador.remoteGround = true;
            }
            else if (!gravitySwitch)
            {
                roda = 2;

                Physics.gravity = new Vector3(0, -9.81f, 0);
                controlaJogador.m_IsGrounded = false;
            }
        }
        if (roda == 1)
        {

            if (controlaJogador.transform.position.y > 5f)
            {

                if (controlaJogador.transform.eulerAngles.x < 180f && controlaJogador.transform.eulerAngles.x >= 0f)
                {
                    controlaJogador.transform.Rotate(10, 0, 0);
                }
                else if (controlaJogador.transform.eulerAngles.x > -180f && controlaJogador.transform.eulerAngles.x < -1)
                {
                    controlaJogador.transform.Rotate(-10, 0, 0);
                }
                else
                {
                    roda = 0;
                }
            }


        }
        else if (roda == 2)
        {
            if (controlaJogador.transform.position.y < 10f)
            {
                if (controlaJogador.transform.eulerAngles.x < -1f && controlaJogador.transform.eulerAngles.x >= -180f)
                {
                    controlaJogador.transform.Rotate(10, 0, 0);

                }
                else if (controlaJogador.transform.eulerAngles.x > 0f && controlaJogador.transform.eulerAngles.x <= 180f)
                {
                    controlaJogador.transform.Rotate(-10, 0, 0);

                }
                else
                {
                    roda = 0;
                }
            }

        }
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.name == "Teto")
        {
            controlaJogador.m_IsGrounded = true;
            controlaJogador.m_Animator.SetBool("OnGround", true);
            if (controlaJogador.transform.eulerAngles.x > 0)
            {
                controlaJogador.transform.localEulerAngles = new Vector3(179f, controlaJogador.transform.localEulerAngles.y, 0);
            }
            else
            {
                controlaJogador.transform.localEulerAngles = new Vector3(-179f, controlaJogador.transform.localEulerAngles.y, 0);
            }

            roda = 0;
        }
        else if (other.gameObject.name == "Chao")
        {
            controlaJogador.m_IsGrounded = true;
            controlaJogador.m_Animator.SetBool("OnGround", true);

                controlaJogador.transform.localEulerAngles = new Vector3(0f, controlaJogador.transform.localEulerAngles.y, 0);
 
     
            roda = 0;
        }
    }
}