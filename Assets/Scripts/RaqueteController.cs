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

    //Indetificando se eu so o player 1
    public bool player1;

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
        //Velocidade multiplicada pelo deltaTime
        float deltaVelocidade = speed * Time.deltaTime;

        //pegando a seta para cima
        //Se eu aperta a seta pra cima ele vai subir a raquete
        if (player1)
        {
            //Controlando a raquete como o player1
            if (Input.GetKey(KeyCode.W))
            {
                    //Almentar o valor do meuY Apenas se for menor q meuLimete
                    //Almentar o valor do meuY
                    meuY = meuY + deltaVelocidade;        
            }
            //Pegando a seta para baixo
            if (Input.GetKey(KeyCode.S))
            {
                    //Almentar o valor do meuY Apenas se for maior q -meuLimete
                    //Diminuindo o valor do meuY
                    meuY = meuY - deltaVelocidade;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {    
                    //Almentar o valor do meuY Apenas se for menor q meuLimete
                    //Almentar o valor do meuY
                    meuY = meuY + deltaVelocidade;
            }
            //Pegando a seta para baixo
            if (Input.GetKey(KeyCode.DownArrow))
            {  
                    //Almentar o valor do meuY Apenas se for maior q -meuLimete
                    //Diminuindo o valor do meuY
                    meuY = meuY - deltaVelocidade;
                
            }
        }
        //Impedindo que eu saia da tela por baixo
        if(meuY < -meuLimete)
        {
            meuY = -meuLimete;
        }
        //Impedindo que eu saia da tela por cima
        if (meuY > meuLimete)
        {
            meuY = meuLimete;
        }


    }
}
