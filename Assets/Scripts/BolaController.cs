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
        //Passando mnha velocidade para minha velocidade
        minhaVelocidae.x = -velocidade;
        minhaVelocidae.y = -velocidade;
        //Adicionando velocidade para esquerda
        meuRB.velocity = minhaVelocidae;

    }
    void Update()
    {
        
    }
}
