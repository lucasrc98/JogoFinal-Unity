using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoFundo : MonoBehaviour
{
    float numeroBack = 4.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1* Time.deltaTime, 0, 0);
    }
    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.transform.tag == "backmover")
        {
            float largura = GetComponent<BoxCollider2D>().size.x;
            Vector3 posicao = GetComponent<BoxCollider2D>().transform.position;
            posicao.x += largura * numeroBack;

            GetComponent<BoxCollider2D>().transform.position = posicao;
        }
    }


   
}

