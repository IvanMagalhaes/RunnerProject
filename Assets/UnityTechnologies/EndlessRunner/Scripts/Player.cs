using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D RBPlayer;
    public int velocidade;
    public Animator animacoesPlayer;
    public Transform ObjAuxiliar;
    public LayerMask LayerPlataforma;
    public bool NoChao;
    public int ForcaPulo;

    // Start is called before the first frame update
    void Start()
    {
        NoChao = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            Pulo();
        }
    }

    void FixedUpdate(){
        RBPlayer.velocity = new Vector2(velocidade, RBPlayer.velocity.y);
        if(Physics2D.OverlapCircle(ObjAuxiliar.position, 0.2f, LayerPlataforma)){
            NoChao = true;
            animacoesPlayer.SetBool("NoChao", true);
        }else{
            NoChao = false;
            animacoesPlayer.SetBool("NoChao", false);
        }
    }

    void Pulo(){
        if(NoChao){
        RBPlayer.AddForce(new Vector2 (0,ForcaPulo));
        }
    }
}
