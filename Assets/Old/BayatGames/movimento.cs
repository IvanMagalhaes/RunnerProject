using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKey("d")){
            transform.Translate(1 * Time.deltaTime,0,0);
        }

        if(Input.GetKey("a")){
            transform.Translate(-1 * Time.deltaTime,0,0);
        }

        if(Input.GetKey("w")){
            transform.Translate(0,10 * Time.deltaTime,0);
        }
        */

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
            transform.Translate(horizontal,vertical,0);
    }
}
