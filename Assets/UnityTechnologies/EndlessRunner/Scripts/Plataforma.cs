using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{

    public GameObject Player;
    public float DistanciaPlayer;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        DistanciaPlayer = Player.transform.position.x - transform.position.x;
        if(DistanciaPlayer > 20){
            Destroy(this.gameObject);
        }
    }
}
