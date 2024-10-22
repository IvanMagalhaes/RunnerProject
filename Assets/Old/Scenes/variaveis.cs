using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour
{
    int vidas;
    float dinheiro;
    string nome;
    bool acordado;

    // Start is called before the first frame update
    void Start()
    {
        vidas=3;
        dinheiro=10.5f;
        nome="jubileu";
        acordado=true;

        Debug.Log(vidas);
        Debug.Log(dinheiro);
        Debug.Log(nome);
        Debug.Log(acordado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
