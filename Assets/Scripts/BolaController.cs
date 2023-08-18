using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{
    //Variavel para saber quem e o meu RigidBoody
    public Rigidbody2D meuRB;
    private Vector2 minhaVelocidae;
    public float velocidade = 5f;

    void Start()
    {
        //Valor aleatorio
        int direcao = Random.Range(0, 4);
        //Passando mnha velocidade para minha velocidade
        if (direcao == 1)// Superior a esquerda
        {
            minhaVelocidae.y = velocidade;
            minhaVelocidae.x = velocidade;
        }
        else if (direcao == 3) // inferior a direita
        {
            minhaVelocidae.y = -velocidade;
            minhaVelocidae.x = velocidade;
        }
        else if (direcao == 2) // Inferior a esquerda
        {
            minhaVelocidae.y = -velocidade;
            minhaVelocidae.x = -velocidade;
        }
        else // superior a direita
        {
            minhaVelocidae.y = velocidade;
            minhaVelocidae.x = -velocidade;
        }
        meuRB.velocity = minhaVelocidae;

    }
    void Update()
    {
        
    }
}
