using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacaoPlayer : MonoBehaviour
{
    public GameObject prefabProjetil;
    public float velocidadex;
    public float velocidadey;
    // Start is called before the first frame update
    void Start()
    {
        velocidadex = 10.0f;
        velocidadey = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.W)) {
            velocidadey = 10f;
            if (this.gameObject.transform.position.y >= 13.73365f) {
                velocidadey = 0;
            }
                transform.Translate(0, velocidadey * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S)){
            velocidadey = 10f;
            if(this.gameObject.transform.position.y <= -12.51851f)
            {
                velocidadey = 0;
            }
            transform.Translate(0, -velocidadey * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A)){
            velocidadex = 10f;
            if(this.gameObject.transform.position.x <= -49.93784f)
            {
                velocidadex = 0;
            }
            transform.Translate(velocidadex * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D)){
            velocidadex = 10f;
            if(this.gameObject.transform.position.x >= 52.5f)
            {
                velocidadex = 0;
            }
            transform.Translate(-velocidadex * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = Instantiate(prefabProjetil) as GameObject;
            go.transform.position = this.transform.position + (this.gameObject.transform.forward * 2.0f);
            go.transform.rotation = this.gameObject.transform.rotation;
            go.GetComponent<Rigidbody>().AddForce(go.transform.forward * 100.0f);

        }


    }
}
