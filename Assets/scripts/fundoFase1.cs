using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fundoFase1 : MonoBehaviour
{
    public float numeroBack = 6.868333f; 
    // Start is called before the first frame update
    void Start()
    {
        numeroBack = 6.868333f;
        numeroBack = gameObject.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1 * Time.deltaTime, 0, 0);
    }
    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.transform.tag == "backmover")
        {
            if (GetComponent<SpriteRenderer>().flipX == true) 
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
            else
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            float largura = GetComponent<BoxCollider2D>().size.x;
            Vector3 posicao = GetComponent<BoxCollider2D>().transform.position;
            posicao.x += largura * numeroBack * 3;

            GetComponent<BoxCollider2D>().transform.position = posicao;
        }
    }
     

}
