using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movmentoInimigo : MonoBehaviour
{
    public float velocidade;
    //float velocidadey;
    // Start is called before the first frame update
    public GameObject Player;
    float direcao;
    float d;
    bool flag;
    float inicio;
    
    void Start() 
    {
        inicio = Time.time;
        flag = false;
        velocidade = this.gameObject.transform.position.x;
        direcao = 0;
        d = (15.9f * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - inicio > 10.0f) {
            Destroy(this.gameObject);

        }
        if (flag == false)
        {
            //transform.position = new Vector3((velocidade + direcao), Player.transform.position.y * 0.4f, 0);
            transform.position = new Vector3((velocidade + direcao), this.gameObject.transform.position.y, 0);
            direcao = direcao - d;
        }
        else {
          transform.Translate(0, -0.2f, -0.9f);
            this.gameObject.GetComponent<Rigidbody>().mass = 0;
            if (Time.time - inicio > 5f)
            {
                Destroy(this.gameObject);
            }
           // transform.Rotate(2f, 0, 0); 
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "player")
        {
          // this.gameObject.transform.Rotate(Vector3.up, -10f * Time.deltaTime ) ;
            //direcao = 0;
          //  d = d * -1;
          // flag = true;
            Destroy(this.gameObject.GetComponent<Rigidbody>());
            Debug.Log("colidio");

        }
    }
}
