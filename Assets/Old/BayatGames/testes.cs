using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testes : MonoBehaviour
{
    /* Variáveis declaradas
    int vidas;
    float dinheiro;
    string nome;
    bool acordado;
    */

    int contador;

    // Start is called before the first frame update
    void Start()
    {
        /* Valor das variáveis
        vidas=3;
        dinheiro=10.5f;
        nome="jubileu";
        acordado=true;
        */
        /* Esse código é responsável por printar os resultados no console
        Debug.Log(vidas);
        Debug.Log(dinheiro);
        Debug.Log(nome);
        Debug.Log(acordado);
        */
        /*Usamos essa função para criar condições
        if(){
        Debug.Log();            
        }else{
        Debug.Log(); 
        }
        */
        /* Laço de repetição
        for(int i = 0; i < 65; i++){
            Debug.Log(i);  
        }
        */

        contador=0;
        while(contador < 10){
            Debug.Log(contador);
            contador += 1;
        }

    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
