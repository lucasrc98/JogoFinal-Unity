using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiro : MonoBehaviour
{ 
    public GameObject barreira;
    float inicio;
    //public GameObject barreiraR;
    // Start is called before the first frame update
    void Start()
    {
        inicio = Time.time;


    }

    // Update is called once per frame
    void Update()
    {

       // this.gameObject.transform.Translate(-Vector3.right* 0.2f);
       if ((Time.time - inicio) > 1.5f)
        {
            Destroy(this.gameObject);
        } 

        //if ((Time.time - inicio) > 2.0f)
       // {
       //     Destroy(this.gameObject);
       // }

    }
    private void posi(Collision collision)
    {
        if(collision.gameObject.tag =="inimigo"){

        }
        if (barreira.transform.position.x >= this.gameObject.transform.position.x)
        {
            Destroy(this.gameObject);
           // GameObject.FindGameObjectWithTag("GameController").GetComponent<PontuacaoScript> ().incrementaPontos();

            /* vidas = vidas - 1;
            Debug.Log("qtd = "+vidas);  */
        }
    }
    
}
