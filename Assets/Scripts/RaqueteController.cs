using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    //O meu Vector 3
    private Vector3 minhaPosicao;
    private float meuY;
    public float speed = 5f;
    private float meuLimete = 3.5f;

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
        if (Input.GetKey(KeyCode.W))
        {
            //Checar se o meu valor e menor q meu limete
            if (meuY < meuLimete)
            {
                //Almentar o valor do meuY Apenas se for menor q meuLimete
                //Almentar o valor do meuY
                meuY = meuY + speed * Time.deltaTime;
            }   
        }
        //Pegando a seta para baixo
        if (Input.GetKey(KeyCode.S))
        {
            if (meuY > -meuLimete)
            {
                //Almentar o valor do meuY Apenas se for maior q -meuLimete
                //Diminuindo o valor do meuY
                meuY = meuY - speed * Time.deltaTime;
            }
        }


    }
}
