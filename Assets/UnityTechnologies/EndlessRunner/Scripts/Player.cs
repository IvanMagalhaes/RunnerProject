using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D RBPlayer;
    public int velocidade;
    public Animator animacoesPlayer;
    public Transform ObjAuxiliar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        RBPlayer.velocity = new Vector2(velocidade, RBPlayer.velocity.y);
        if(Physics2D.OverlapCircle(ObjAuxiliar.position, 0.2f, ));
    }
}
