using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float DistanciaAtualPlataforma;
    float DistanciaGerarPlataforma;
    public float TamanhoPlataforma;
    public Transform Player;
    public GameObject Plataforma;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GerarPlataforma();
        Debug.Log(DistanciaGerarPlataforma);
        
    }

    void GerarPlataforma(){
        DistanciaGerarPlataforma = DistanciaAtualPlataforma - Player.position.x;
        if(DistanciaGerarPlataforma < 30){
            Instantiate(Plataforma, new Vector3(DistanciaAtualPlataforma, -4, 0), Quaternion.identity);
            DistanciaAtualPlataforma += TamanhoPlataforma;
        }
    }
}
