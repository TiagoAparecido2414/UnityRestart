using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    //O meu Vector 3
    private Vector3 minhaPosicao;
    public float meuY;

    void Start()
    {
        //Pegando  posicao inicial da raquete e aplicando a minha posição
        minhaPosicao = transform.position;
    }
    void Update()
    {
        //Passando o meuY para o eixo Y da minhaPosicao
        minhaPosicao.y = meuY;

        //Modificar a posição da minha raquete
        transform.position = minhaPosicao;

        //pegando a seta para cima
        //Se eu aperta a seta pra cima ele vai subir a raquete
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Almentar o valor do meuY
            meuY = meuY + 0.01f;
        }
        //Pegando a seta para baixo
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Diminuindo o valor do meuY
            meuY = meuY - 0.01f;

        }


    }
}
